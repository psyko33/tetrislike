using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag3 : MonoBehaviour {


	private bool IsDrag = false;
	private float distance;
	public float vitesseLancer ;
	public float arc;
	public float vitesse ; 

	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position , Camera.main.transform.position);
		IsDrag = true ; 
	}

	public void OnMouseUp()
	{
		this.GetComponent<Rigidbody>().useGravity = true;
		this.GetComponent<Rigidbody>().velocity += this.transform.forward * vitesseLancer;
		this.GetComponent<Rigidbody>().velocity += this.transform.up * arc; 
		IsDrag = false; 

	}
	
	void Update () {
		if(IsDrag)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = Vector3.Lerp ( this.transform.position , rayPoint , vitesse*Time.deltaTime);

		}
		
	}
}
