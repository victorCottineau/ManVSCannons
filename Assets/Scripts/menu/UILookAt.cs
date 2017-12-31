using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAt : MonoBehaviour {

    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("player");
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(player.transform);
        // transform.rotation = Quaternion.AngleAxis(angle: 180, axis: Vector3.up);
        transform.rotation = Quaternion.LookRotation(transform.position - player.transform.position);
    }
}
