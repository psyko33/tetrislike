﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
	if (other.CompareTag("A"))
		{
			Debug.Log("Mort");
			other.transform.GetComponent<FormeManager>().Death();
			
		}

	}

}