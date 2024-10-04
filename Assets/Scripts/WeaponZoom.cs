using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using StarterAssets;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera FPSCam;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    FirstPersonController fpsController;
    [SerializeField] float zoomOutSpeed = 1f;
    [SerializeField] float zoomInSpeed = .1f;
    bool zoomedInToggle = false;
    StarterAssetsInputs _input;
    private void Start() {
        fpsController = GetComponent<FirstPersonController>();
        _input = GetComponent<StarterAssetsInputs>();
    }
    private void Update() {
        if(_input.aim)
        {
            _input.aim = false;
            Debug.Log("pressed");
            {
                if(zoomedInToggle == false)
                {   
                    zoomedInToggle = true;
                    FPSCam.m_Lens.FieldOfView = zoomedInFOV;
                    fpsController.RotationSpeed = zoomInSpeed;
                }
                else
                {
                    zoomedInToggle = false;
                    FPSCam.m_Lens.FieldOfView = zoomedOutFOV;
                    fpsController.RotationSpeed = zoomOutSpeed;
                }
            }
        }
    }
}
