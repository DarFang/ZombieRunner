using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera FPSCam;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    bool zoomedInToggle = false;
    private void Update() {
        if(Input.GetMouseButton(1))
        {
            if(zoomedInToggle == false)
            {   
                zoomedInToggle = true;
                FPSCam.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomedInToggle = false;
                FPSCam.fieldOfView = zoomedOutFOV;
            }
        }
    }
}
