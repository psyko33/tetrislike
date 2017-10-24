using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2 : MonoBehaviour {


	private float force ;
	Vector3 startPos ; 
	Vector3 endPos ;
	Vector3 direction ;
	public float arc; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		startPos = Input.mousePosition;
		Debug.Log("ligne 1 ok");
		startPos.z =transform.position.z - Camera.main.transform.position.z;
		Debug.Log("ligne 2 ok");
		startPos = Camera.main.ScreenToWorldPoint(startPos);
		Debug.Log("ligne 3 ok");
		Debug.Log( "the mouse down pos is " + startPos);
	}

	void OnMouseUp()
	{
		endPos = Input.mousePosition;
		endPos.z = transform.position.z - Camera.main.transform.position.z;
		endPos = Camera.main.ScreenToWorldPoint(endPos);
		Debug.Log( "the mouse up pos is " + endPos);

		direction = endPos - startPos ; 
		Debug.Log( "direction is  " + direction);
		direction.Normalize();
		force = (endPos.y - startPos.y)*2; 
		Debug.Log("force = " + force);
		Vector3 tmpDir = new Vector3(direction.x,arc,direction.y);
		GetComponent<Rigidbody>().AddForce (tmpDir * force,ForceMode.Impulse);
	}

	void OnMouseDrag()
	{

		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y,0);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = mousePosition;
	}
}
