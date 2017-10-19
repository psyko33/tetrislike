using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("A"))
		{
			Debug.Log("Checkpoint") ;
			other.transform.GetComponent<FormeManager>().CheckPointTake(transform.position) ;
			gameObject.SetActive(false) ;

		}
	}
}
