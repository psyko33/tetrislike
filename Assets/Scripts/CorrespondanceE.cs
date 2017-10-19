using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrespondanceE : MonoBehaviour {

	public GameObject FormeE ;
	public GameObject FormeEMur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("E"))
        {
            Destroy(other.gameObject);
            FormeEMur.SetActive(true);
        }

	}
}
