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
	public GameObject antiDrag;
	public Button buttonPause;

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
			Time.timeScale = 1;
		}

		public void QuitButton()
		{
			Application.Quit() ;
		}
		
		public void Timer()
		{

	       		menueFin.SetActive(true);
	       		game.SetActive(false);
	       		Time.timeScale = 0; 
	       		antiDrag.SetActive(true);
	        
		}




}