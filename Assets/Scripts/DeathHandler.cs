using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Canvas GameOverCanvas;
    void Start()
    {
        GameOverCanvas.enabled = false;
    }
    public void HandleDeath()
    {        
        GameOverCanvas.enabled = true;
        GetComponent<FirstPersonController>().enabled = false;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
