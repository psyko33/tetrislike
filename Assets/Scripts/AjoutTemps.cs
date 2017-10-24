using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutTemps : MonoBehaviour {

public GameObject tableaux;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		tableaux.GetComponent<Tableaux>().AddTimer();
	}
}
