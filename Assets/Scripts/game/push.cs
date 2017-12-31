using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour  
{
    [SerializeField] private AudioClip PushSound;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("monster"))
        {
            //Vector3 playerPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            //Vector3 otherPosition = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
            Vector3 pushDirection = new Vector3(other.gameObject.transform.position.x - gameObject.transform.position.x, 1, other.gameObject.transform.position.z - gameObject.transform.position.z);
            other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            other.gameObject.GetComponent<AgentScript>().enabled = false;
            //other.gameObject.GetComponent<WakeUp>().enabled = true;
            other.gameObject.GetComponent<Rigidbody>().AddForce(10*pushDirection, ForceMode.Impulse);
        }
    }
}
