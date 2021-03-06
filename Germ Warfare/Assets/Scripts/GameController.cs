﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject bad;
	public Vector2 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves () {
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector2 spawnPositionBad = new Vector2 (spawnValues.x, Random.Range (-spawnValues.y, spawnValues.y));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (bad, spawnPositionBad, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
