using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class vision : MonoBehaviour
{
    //создание необходимых переменых
    public GameObject PlaneMarkerPrefab;
    private Vector2 touchpos;
    private ARRaycastManager ARRaycastManagerScript;
    public GameObject spawn;
    private int c = 0;
    private GameObject Cube;
    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();

        PlaneMarkerPrefab.SetActive(false);//выключение модели при старте
    }

    // Update is called once per frame
    void Update()
    {
        ShowMarker();//вызов функции каждый кадр

    }

    void ShowMarker()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if (hits.Count > 0)//проверка наличия плоскости
        {
            PlaneMarkerPrefab.transform.position = hits[0].pose.position;//координаты плоской модели с названием глагола
            PlaneMarkerPrefab.SetActive(true);//включение плоской модели с названием глагола при наличии плоскости
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)//проверка на нажатие на экран
            {
                if (c == 1)
                {
                    Destroy(Cube);//удаление модели, если она есть
                    c = 0;
                }
                Cube = Instantiate(spawn, hits[0].pose.position, spawn.transform.rotation);//создание новой модели
                c++;

            }
        }
        else
        {
            PlaneMarkerPrefab.SetActive(false);//выключение плоской модели с названием глагола при отсутствии плоскости 
        }
    }
}
