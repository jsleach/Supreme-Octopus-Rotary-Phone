﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnGameObjects : MonoBehaviour
{
	private ObjectPool pool;
	private Transform positionTransform;

	public float minSecondsBetweenSpawning = 3.0f;
	public float maxSecondsBetweenSpawning = 6.0f;

	private float savedTime;
	private float secondsBetweenSpawning;
	private Transform spawnerTransform;

	void Start() {		
		pool = this.gameObject.GetComponent<ObjectPool> ();
		positionTransform = this.gameObject.GetComponent<Transform>();
	}

	// Use this for initialization
	public void BeginSpawning ()
	{
		MakeThingToSpawn ();
		savedTime = Time.time;
		secondsBetweenSpawning = Random.Range (minSecondsBetweenSpawning, maxSecondsBetweenSpawning);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (savedTime != 0.0f && Time.time - savedTime >= secondsBetweenSpawning) { // is it time to spawn again?
			MakeThingToSpawn ();
			savedTime = Time.time; // store for next spawn
			secondsBetweenSpawning = Random.Range (minSecondsBetweenSpawning, maxSecondsBetweenSpawning);
		}	
	}


	void MakeThingToSpawn ()
	{
		var avilableObjects = pool.GetAvailablePoolObjectNames ();
		if (avilableObjects.Count > 0) {
			var randomIndex = (int) System.Math.Floor(Random.Range(0, avilableObjects.Count) - 0.01f);
			var obj = pool.GetObjectForType (avilableObjects[randomIndex], true);
			if (obj != null) {
				//obj.GetComponent<ObstacleMovement> ().BeginMoving ();
				obj.transform.position = positionTransform.position;
			}
		}
	}

	public void UnspawnThing(GameObject obj) {
		pool.PoolObject (obj);
	}
}
