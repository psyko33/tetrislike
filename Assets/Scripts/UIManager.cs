using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour 

{

	public GameObject pause;
	public GameObject boutique;
	public GameObject game;
	public GameObject menueFin;
	public GameObject menueFin2;
	public GameObject antiDrag;
	public GameObject appuyez;
	public GameObject maintenez;
	public GameObject glissez;
	public GameObject relachez;
	public Button buttonPause;
	public Text scoreFinal;


	private static UIManager instance;
    public static UIManager Instance () 
    {
        return instance;
    }

    void Awake (){
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else 
        {
            instance = this;
        }
    }
   

		 
		  void Start()
	    {
	   		antiDrag.SetActive(false);
	   		Time.timeScale =1 ;
	    }


	    void Update()
	    {
	  
	    }

	    
		public void Pause ()
		{
			
			if (Time.timeScale == 1)
			{
			Time.timeScale = 0;
			}
			else
			{
			Time.timeScale = 1;
			}
			pause.SetActive(true);
			buttonPause.interactable = false;
			antiDrag.SetActive(true);
		}
		
		

		public void GoToSceneLancement ()
		{
		 SceneManager.LoadScene("SceneLancement");
		 Time.timeScale = 1;	
		}

		public void GoToSceneLobby ()
		{
		 SceneManager.LoadScene("SceneLobby");
		 Time.timeScale = 1;	
		}
		
		public void LoadWorld1 ()
		{
		 SceneManager.LoadScene("SceneKevin");
		}
		
		public void LoadTuto ()
		{
		 SceneManager.LoadScene("SceneTuto");	
		}

		public void LoadBoutique ()
		{
		boutique.SetActive(true);
		pause.SetActive (false);

		}
		public void ReturnPause ()
		{
		boutique.SetActive(false);
		pause.SetActive (true);
		}

		public void Continuer() 
		{
			game.SetActive (true);
			pause.SetActive(false);
			antiDrag.SetActive(false);
			Time.timeScale = 1;
			buttonPause.interactable = true;

		}

		public void ReloadScene ()
		{
			SceneManager.LoadScene("SceneKevin");
			
		}

		public void QuitButton()
		{
			Application.Quit() ;
		}
		
		public void Timer()
		{

	       		menueFin.SetActive(true);
	       		Time.timeScale = 0; 
	       		antiDrag.SetActive(true);
	        
		}

		public void TimerWin()
		{
				menueFin2.SetActive(true);
				Time.timeScale = 0;
				antiDrag.SetActive(true);
		}


		public void GoToMaintenez ()
		{
			appuyez.SetActive(false);
			maintenez.SetActive(true);
		}

		public void ReturnAppuyer ()
		{
			appuyez.SetActive(true);
			maintenez.SetActive(false);
		}


		public void GoToGLissez ()
		{
			maintenez.SetActive(false);
			glissez.SetActive(true);
		}

		public void ReturnMaintenez ()
		{
			maintenez.SetActive(true);
			glissez.SetActive(false);
		}

		public void GoToRelachez ()
		{
			glissez.SetActive(false);
			relachez.SetActive(true);
		}

		public void ReturnGlissez ()
		{
			relachez.SetActive(false);
			glissez.SetActive(true);
		}


}