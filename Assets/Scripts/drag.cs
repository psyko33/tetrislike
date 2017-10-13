using UnityEngine;
using System.Collections;


//Drag
public class drag : MonoBehaviour {
	
	float distance = 5;
	 Vector3 mMouseDownPos;
 	Vector3 mMouseUpPos;
 	public float speed = .1f;
 
	


	void OnMouseDrag()
	{

		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}


 
 	void OnMouseDown() 
 		{
     
    		 mMouseDownPos = Input.mousePosition;
   			 Debug.Log( "the mouse down pos is " + mMouseDownPos.y.ToString() );
   			 mMouseDownPos = Input.mousePosition;
    		 Debug.Log( "the mouse down pos is " + mMouseDownPos.z.ToString() );
     		 mMouseDownPos.z = 0;
	 	}
 
 	void OnMouseUp() 
 		{

     		mMouseUpPos = Input.mousePosition;
    		mMouseUpPos = Input.mousePosition;
     		mMouseUpPos.z = 0;
     		var direction = mMouseDownPos - mMouseUpPos;
     		direction.Normalize();
     		GetComponent<Rigidbody>().AddForce (-direction * speed,ForceMode.Impulse);
     		Debug.Log( "the mouse up pos is " + mMouseUpPos.ToString() );
 		}
}
	