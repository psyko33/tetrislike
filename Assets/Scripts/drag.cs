using UnityEngine;
using System.Collections;


//Drag
public class drag : MonoBehaviour {
	
	float distance = 7;
	Vector3 mMouseDownPos;
 	Vector3 mMouseUpPos;
 	public float speed = .1f;
 	public float arc = 0.5f;
	
 	void OnMouseDown ()
 	{
 		mMouseDownPos = transform.position;
 	}

	void OnMouseDrag()
	{

		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}

 
 	void OnMouseUp() 
 		{

     		mMouseUpPos = transform.position;
     		// mMouseUpPos.z = 0;
     		var direction = mMouseUpPos - mMouseDownPos;
     		direction.Normalize();
     		Vector3 tmpDir = new Vector3(direction.x,arc,direction.y);
     		GetComponent<Rigidbody>().AddForce (tmpDir * speed,ForceMode.Impulse);
     		Debug.Log( "the mouse up pos is " + mMouseUpPos);
 		}
}
	

