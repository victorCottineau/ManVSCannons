using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGame : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Game");
    }
}
