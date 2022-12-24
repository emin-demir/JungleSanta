using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envanter : MonoBehaviour
{

    GameObject gameO;

    [SerializeField]
    bool gameUpdate;
    void Start()
    {
        
    }


    void Update()
    {   
        if(Input.GetKey(KeyCode.E) && gameUpdate != true)
        {
            gameO.SetActive(true);
            gameUpdate = false;
        }
        if(Input.GetKey(KeyCode.E) && gameUpdate == true)
        {
            gameO.SetActive(false);
            gameUpdate = true;
        }
    }
}
