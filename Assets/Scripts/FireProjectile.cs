using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Transform firingPoint;
    public Weapons weapons;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(weapons.currentProjectile, firingPoint.position, firingPoint.rotation);
        }
        
    }
}
