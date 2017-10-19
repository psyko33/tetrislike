using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrouMur : MonoBehaviour {

public int numHoles;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("space"))
		{
			UpdateHoles();

		}
	}

	void UpdateHoles()
	{
		numHoles--;
		if(numHoles == 0)
		{
			Debug.Log("Changementdemur");

		}
		
		else if(numHoles != 0)
		{
			UpdateHoles();
		
		}
	}
}
