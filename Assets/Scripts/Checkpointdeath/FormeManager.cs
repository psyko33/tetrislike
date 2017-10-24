using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormeManager : MonoBehaviour  {
	
	private Vector3 currentCheckpointPosition;
	private Vector3 currentCheckpointRotation;
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheckPointTakePosition(Vector3 checkpointPosition)
	{
		currentCheckpointPosition = checkpointPosition ;
	}
	public void CheckPointTakeRotation(Vector3 checkpointRotation)
	{
		currentCheckpointRotation= checkpointRotation ;
	}

	public void Death()
	{	
		
		GetComponent<Rigidbody>().velocity = new Vector3(0,0,0) ;
		GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
		transform.rotation = Quaternion.Euler(currentCheckpointRotation);
		transform.position = currentCheckpointPosition ;
	}
	

}
		