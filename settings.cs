using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneLoad(int sceneid)//создание функции, которая взависимости от аргумента переключает на нужную сцену
    {
        SceneManager.LoadScene(sceneid);
    }
}
