using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrespondanceB : MonoBehaviour {

	public GameObject FormeB;
	public GameObject FormeBMur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("B"))
        {
            Destroy(other.gameObject);
            FormeBMur.SetActive(true);
        }

	}
}
