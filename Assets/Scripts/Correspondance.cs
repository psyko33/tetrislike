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
    
    public GameObject FormeD2 ;
    public GameObject FormeD2Mur;

    public GameObject FormeB2 ;
    public GameObject FormeB2Mur;
    
    public GameObject FormeA2 ;
    public GameObject FormeA2Mur;




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

                Tableaux.Instance().CheckWin();
                FormeEMur.SetActive(true);
                Destroy(gameObject);
            }
                
        if (other.gameObject.tag == gameObject.tag  && other.gameObject.tag == ("F"))
            {

                Tableaux.Instance().CheckWin();
                FormeFMur.SetActive(true);
                Destroy(gameObject);
            }

        if (other.gameObject.tag == gameObject.tag  && other.gameObject.tag == ("D2"))
            {

                Tableaux.Instance().CheckWin();
                FormeD2Mur.SetActive(true);
                Destroy(gameObject);
            }

        if (other.gameObject.tag == gameObject.tag  && other.gameObject.tag == ("B2"))
            {

                Tableaux.Instance().CheckWin();
                FormeB2Mur.SetActive(true);
                Destroy(gameObject);
            }
        if (other.gameObject.tag == gameObject.tag  && other.gameObject.tag == ("A2"))
            {

                Tableaux.Instance().CheckWin();
                FormeA2Mur.SetActive(true);
                Destroy(gameObject);
            }
                
	}
}
