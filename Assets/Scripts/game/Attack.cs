using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    private GameObject player;
    private GameObject SpawnPoint;
    private GameObject ParticleSystem;
    private Vector3 Distance;
    private float DistanceF;

    private float fireStamp;

    void Start()
    {
        fireStamp = 0;
        player = GameObject.FindGameObjectWithTag("player");
        SpawnPoint = transform.Find("SpawnPoint").gameObject;
        ParticleSystem = transform.Find("ParticleSystem").gameObject;
        ParticleSystem.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
        Distance = gameObject.transform.position - player.transform.position;
        DistanceF = Distance.magnitude;
        if (DistanceF < 30) 
        {
            transform.LookAt(player.transform);
            if (fireStamp < Time.time)
            {
                fireStamp = Time.time + 10;
                ParticleSystem.SetActive(true);
                StartCoroutine(Fire());
            }
        }
	}

    IEnumerator Fire() 
    {
        yield return new WaitForSeconds(1.0f);
        ParticleSystem.SetActive(false);
        GameObject instance = Instantiate(Resources.Load("Bullet"), SpawnPoint.transform.position, SpawnPoint.transform.rotation) as GameObject;
    }
    
}
