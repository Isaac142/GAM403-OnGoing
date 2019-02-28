using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float playerSpeed;
    public float speedBurst = 2f;
    public int ammo = 100;
    public int health = 100;
    public float accuracy = 15.5f;
    public string player = "Isaac";
    public Vector3 starting;

    // Start is called before the first frame update
    void Start()
    {
        ammo = ammo + 20;
        Debug.Log("My Ammo Is: " + ammo);
        transform.position = starting;
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = playerSpeed + speedBurst;

        transform.Translate(Vector3.up * playerSpeed);
    }
}
