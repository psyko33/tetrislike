﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormeManager : MonoBehaviour  {
	
	private Vector3 currentCheckpointPosition;

	void Awake()
	{
		//DontDestroyOnLoad(transform.gameObject) ;
	}
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheckPointTake(Vector3 checkpointPosition)
	{
		currentCheckpointPosition = checkpointPosition ;
	}

	public void Death()
	{	
		transform.position = currentCheckpointPosition ;
		GetComponent<Rigidbody>().velocity = new Vector3(0,0,0) ;
	}

}
		