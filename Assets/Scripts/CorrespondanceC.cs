using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrespondanceC : MonoBehaviour {

	public GameObject FormeC;
	public GameObject FormeCMur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("C"))
        {
            Destroy(other.gameObject);
            FormeCMur.SetActive(true);
        }

	}
}
