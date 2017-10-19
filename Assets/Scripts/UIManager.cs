using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 

{

	public GameObject pause;
	public GameObject boutique;
	public GameObject game;
	public int timeLeft = 75;
    public Text countdownText;

		 
		  void Start()
	    {
	        StartCoroutine("LoseTime");
	    }


	    void Update()
	    {
	        countdownText.text = (" " + timeLeft);

	        if (timeLeft <= 0)
	        {
	            StopCoroutine("LoseTime");
	            countdownText.text = "Times Up!";
	        }
	    }

		
	  

	    IEnumerator LoseTime()
	    {
	        while (true)
	        {
	            yield return new WaitForSeconds(1);
	            timeLeft--;
	        }
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
		
		}
		
		public void LoadPause ()
		{
			
			pause.SetActive(true);
			//button.interactable = false;
		}	

		public void GoToSceneLobby ()
		{
		 Application.LoadLevel("SceneLobby");	
		}
		
		public void LoadWorld1 ()
		{
		 Application.LoadLevel("SceneMikael");	
		}
		
		public void LoadBoutique ()
		{
		boutique.SetActive(true);
		pause.SetActive (false);

		}
		public void LoadGame ()
		{
		boutique.SetActive(false);
		game.SetActive (true);
		}

		public void QuitButton()
		{
			Application.Quit() ;
		}

}