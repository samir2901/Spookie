using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fire;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFire();
            Debug.Log("Space Key Pressed");
        }
        
    }

    void ShootFire()
    {
        Instantiate(fire, firePoint.position, fire.transform.rotation);
        //Debug.Log("I Am Shooting");
    }
}
