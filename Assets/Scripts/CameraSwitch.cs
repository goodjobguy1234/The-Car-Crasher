using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public bool isFirstPerson;

    void Start() {
        cam1.SetActive(true);
        cam2.SetActive(false);
        isFirstPerson = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("ChangeView")) {
            isFirstPerson = !isFirstPerson;
          
        } 

        if (isFirstPerson) {
            cam2.SetActive(true);
            cam1.SetActive(false);
        } else {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
}
