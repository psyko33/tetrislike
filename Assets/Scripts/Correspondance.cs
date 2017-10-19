using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correspondance : MonoBehaviour {

	public GameObject FormeA ;
	public GameObject FormeAMur;

	public GameObject FormeB;
	public GameObject FormeBMur;
	
	public GameObject FormeC;
	public GameObject FormeCMur;

	public GameObject FormeD ;
	public GameObject FormeDMur;

	public GameObject FormeE ;
	public GameObject FormeEMur;

	public GameObject FormeF ;
	public GameObject FormeFMur;





	void OnTriggerEnter(Collider other) {
       
        if (other.gameObject.tag == gameObject.tag && other.gameObject.tag ==("A"))
       		{
            	Destroy(gameObject);
           		FormeAMur.SetActive(true);
        	}

        if (other.gameObject.tag == gameObject.tag	&& other.gameObject.tag == ("B"))
        	{
            	Destroy(gameObject);
            	FormeBMur.SetActive(true);
        	}
        // if (other.gameObject.tag == gameObject.tag)
       	// 	{
        //     	Destroy(gameObject);
        //     	FormeCMur.SetActive(true);
        // 	}
        // if (other.gameObject.tag == gameObject.tag)
        // 	{
        //     	Destroy(gameObject);
        //     	FormeDMur.SetActive(true);
        // 	}
        // if (other.gameObject.tag == gameObject.tag)
        // 	{
        //    		Destroy(gameObject);
        //     	FormeEMur.SetActive(true);
        // 	}
        // if (other.gameObject.tag == gameObject.tag)
        // 	{
        //     	Destroy(gameObject);
        //     	FormeFMur.SetActive(true);
        // 	}
	}
}
