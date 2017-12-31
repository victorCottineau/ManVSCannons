using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerOverMenu : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("menuBoundary"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
