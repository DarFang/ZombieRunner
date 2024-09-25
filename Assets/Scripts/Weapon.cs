
using StarterAssets;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] StarterAssetsInputs _Input;

    void Update()
    {
        if(_Input.fire)
        {
            _Input.fire = false;
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range);
        if(hit.collider != null)
        {
            Debug.Log("I hit" + hit.transform.name);
        }
    }
}
