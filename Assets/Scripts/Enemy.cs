using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject player;
    public float dist;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        StartAgent(player.transform.position);
        InvokeRepeating("StopAgent", 5, 7);

    }

    // Update is called once per frame
    void Update()
    {

        dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist <= 15.0f)
        {
            StartAgent(player.transform.position);
            transform.LookAt(player.transform);
        }

        if (dist <= 3.0f)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else
            GetComponent<Renderer>().material.color = Color.red;
    }

    void StopAgent()
    {
        agent.isStopped = true;
    }

    void StartAgent(Vector3 newPos)
    {
        agent.isStopped = false;
        agent.SetDestination(newPos);
    }
}
