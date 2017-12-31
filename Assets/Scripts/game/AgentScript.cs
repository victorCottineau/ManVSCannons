using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour {

    private GameObject player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
        
    }
}
