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

        Debug.Log("Coucou");
       
        if (other.gameObject.tag == gameObject.tag && other.gameObject.tag ==("A"))
       		{

                Tableaux.Instance().CheckWin();
                FormeAMur.SetActive(true);
            	Destroy(gameObject);
           		
           		
        	}

        if (other.gameObject.tag == gameObject.tag	&& other.gameObject.tag == ("B"))
        	{

                Tableaux.Instance().CheckWin();
                FormeBMur.SetActive(true);
            	Destroy(gameObject);
            	
            	

        	}
       if (other.gameObject.tag == gameObject.tag   && other.gameObject.tag == ("C"))
            {

                Tableaux.Instance().CheckWin();
                FormeCMur.SetActive(true);
                Destroy(gameObject);
            }
                
        if (other.gameObject.tag == gameObject.tag  && other.gameObject.tag == ("D"))
            {

                Tableaux.Instance().CheckWin();
                FormeDMur.SetActive(true);
                Destroy(gameObject);
            }
                
       if (other.gameObject.tag == gameObject.tag   && other.gameObject.tag == ("E"))
            {

                // Tableaux.Instance().CheckWin();
                FormeEMur.SetActive(true);
                Destroy(gameObject);
            }
                
        if (other.gameObject.tag == gameObject.tag  && other.gameObject.tag == ("F"))
            {

                Tableaux.Instance().CheckWin();
                FormeFMur.SetActive(true);
                Destroy(gameObject);
            }
                
	}
}
