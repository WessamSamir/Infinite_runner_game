using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform sonic;
   
     
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(sonic.position);
    
    }
}


