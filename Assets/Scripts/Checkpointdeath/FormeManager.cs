using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormeManager : MonoBehaviour  {
	
	private Vector3 currentCheckpointPosition;
	private Vector3 currentCheckpointRotation;
	private float rotationX;
	private float rotationY;
	private float rotationZ;

	void Start ()
	{
		rotationX = transform.rotation.eulerAngles.x;
		rotationY = transform.rotation.eulerAngles.y;
		rotationZ = transform.rotation.eulerAngles.z;
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheckPointTakePosition(Vector3 checkpointPosition)
	{
		currentCheckpointPosition = checkpointPosition ;
	}

	public void Death()
	{	
		
		GetComponent<Rigidbody>().velocity = new Vector3(0,0,0) ;
		GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
		transform.rotation = Quaternion.Euler(rotationX,rotationY,rotationZ);
		transform.position = currentCheckpointPosition ;
	}
	

}
		