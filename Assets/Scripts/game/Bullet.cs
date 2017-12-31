using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject player;
    private Vector3 aim;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        Physics.IgnoreLayerCollision(8, 9, true);
        aim = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(aim * 5, ForceMode.Force);


    }
    private void OnCollisionEnter(Collision collision)
    {
       // Destroy(collision.gameObject);
    }
}