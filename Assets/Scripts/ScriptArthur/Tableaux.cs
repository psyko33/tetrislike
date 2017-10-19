using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableaux : MonoBehaviour {


	public GameObject[] tableauxIdx;
	private int nombreIdx;
	private GameObject currentWall;
	public int numHoles;

	// Use this for initialization
	void Start () 
	{
		nombreIdx = 1;
		PopMur();

	}
	
	void PopMur()
	{
		
		currentWall = Instantiate(tableauxIdx[nombreIdx],transform.position,Quaternion.identity);
	
	}
	


	void Update () 
	{
		/*if (Input.GetKeyDown("space"))
		{
			UpdateWall();

		}*/
			

	}

	void UpdateWall()
	{
		Destroy(currentWall);
		if(nombreIdx == 21)
		{
			Debug.Log("fini");
		}
		else if (nombreIdx != 21)
		{
			nombreIdx ++;
			PopMur();
		}	
	}

	public void UpdateHoles()
	{
		numHoles--;
		if(numHoles == 0)
		{
			UpdateWall();

		}
	}

}