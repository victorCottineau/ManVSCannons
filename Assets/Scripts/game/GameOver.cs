using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("boundary"))
        {
            Application.LoadLevel("GameOver");
        }
    }
}