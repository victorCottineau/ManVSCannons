using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {


    private GameObject scoreManager;
    private bool scored;

    void Start()
    {
        scored = false;
        if (GameObject.Find("scoreManager"))
        {
            scoreManager = GameObject.Find("scoreManager");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("boundary") || collision.gameObject.CompareTag("menuBoundary"))
        {
            if (!scored && tag=="monster" && scoreManager != null)
            {
                scored = true;
                scoreManager.GetComponent<Score>().IncreaseScore();
            }
            Destroy(gameObject);
        }
        if (tag=="bullet" && collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
        if (tag == "bullet" && collision.gameObject.CompareTag("player"))
        {
            Application.LoadLevel(2);
        }
    }
}
