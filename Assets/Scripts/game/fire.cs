using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
    private GameObject aim;
    private float timeStamp;

	// Use this for initialization
	void Start () {
        aim = gameObject.transform.Find("aim").gameObject;
        aim.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && timeStamp <= Time.time)
        {
            aim.SetActive(true);
            timeStamp = Time.time + 2;
            StartCoroutine(Disable());
        }
	}
    IEnumerator Disable()
    {
        yield return new WaitForSeconds(1.0f);
        aim.SetActive(false);
    }
}
