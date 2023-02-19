using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class vision : MonoBehaviour
{
    //�������� ����������� ���������
    public GameObject PlaneMarkerPrefab;
    private Vector2 touchpos;
    private ARRaycastManager ARRaycastManagerScript;
    public GameObject spawn;
    private int c = 0;
    private GameObject Cube;
    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();

        PlaneMarkerPrefab.SetActive(false);//���������� ������ ��� ������
    }

    // Update is called once per frame
    void Update()
    {
        ShowMarker();//����� ������� ������ ����

    }

    void ShowMarker()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if (hits.Count > 0)//�������� ������� ���������
        {
            PlaneMarkerPrefab.transform.position = hits[0].pose.position;//���������� ������� ������ � ��������� �������
            PlaneMarkerPrefab.SetActive(true);//��������� ������� ������ � ��������� ������� ��� ������� ���������
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)//�������� �� ������� �� �����
            {
                if (c == 1)
                {
                    Destroy(Cube);//�������� ������, ���� ��� ����
                    c = 0;
                }
                Cube = Instantiate(spawn, hits[0].pose.position, spawn.transform.rotation);//�������� ����� ������
                c++;

            }
        }
        else
        {
            PlaneMarkerPrefab.SetActive(false);//���������� ������� ������ � ��������� ������� ��� ���������� ��������� 
        }
    }
}
