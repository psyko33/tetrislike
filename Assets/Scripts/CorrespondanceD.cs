using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrespondanceD : MonoBehaviour {

	public GameObject FormeD ;
	public GameObject FormeDMur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("D"))
        {
            Destroy(other.gameObject);
            FormeDMur.SetActive(true);
        }

	}
}
