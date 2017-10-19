using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrespondanceF : MonoBehaviour {

	public GameObject FormeF ;
	public GameObject FormeFMur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("F"))
        {
            Destroy(other.gameObject);
            FormeFMur.SetActive(true);
        }

	}
}
