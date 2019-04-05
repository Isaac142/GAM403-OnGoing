using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist <= 15.0f)
        {
            transform.LookAt(player.transform);
        }

        if (dist <= 3.0f)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else
            GetComponent<Renderer>().material.color = Color.red;
    }
}
