using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waves : MonoBehaviour {

    [SerializeField] private int[] wave;
    [SerializeField] private GameObject[] monster;

    private int waveIndex;
    private int waveTotal;
    private int monsterIndex;
    private GameObject scoreManager;
    private GameObject newWave;

    // Use this for initialization
    void Start () {
        waveIndex = 0;
        waveTotal = wave[waveIndex];
        monsterIndex = 0;
        if (GameObject.Find("scoreManager"))
        {
            scoreManager = GameObject.Find("scoreManager");
        }
        if (GameObject.Find("newWave"))
        {
            newWave = GameObject.Find("newWave");
        }
        newWave.SetActive(false);
        SpawnMonster();
    }
	
	// Update is called once per frame
	void Update () {
		if (waveTotal <= scoreManager.GetComponent<Score>().ScoreNbr())
        {
            StartCoroutine(newWaveDisplay());
            waveIndex++;
            waveTotal += wave[waveIndex];
            SpawnMonster();
        }
	}

    private void SpawnMonster()
    {
        for (int i = monsterIndex; i < waveTotal; i++)
        {
            monster[i].SetActive(true);
        }
        monsterIndex += wave[waveIndex];
    }

    IEnumerator newWaveDisplay()
    {
        newWave.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        newWave.SetActive(false);
    }
}
