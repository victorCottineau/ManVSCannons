using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Rigidbody>().IsSleeping())
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            GetComponent<AgentScript>().enabled = true;
            GetComponent<WakeUp>().enabled = false;
        }
	}
}
