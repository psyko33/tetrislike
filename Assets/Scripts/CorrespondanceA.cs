using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrespondanceA : MonoBehaviour {

	public GameObject FormeA ;
	public GameObject FormeAMur;
	public int nbWallActif;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("A"))
        {
            Destroy(other.gameObject);
            FormeAMur.SetActive(true);
            nbWallActif ++;

        }

	}
}
