using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutoManager : MonoBehaviour 
{

	public GameObject appuyez;
	public GameObject maintenez;
	public GameObject glissez;
	public GameObject relachez;
	public GameObject background;
	public GameObject popuptuto;
	public GameObject tutotimer;
	public AudioSource button;

		public void GoToAppuyez ()
		{
			button.Play();
			 background.SetActive(false);
			 popuptuto.SetActive(false);
			 appuyez.SetActive(true);
		}

		public void GoToMaintenez ()
		{
			button.Play();
			appuyez.SetActive(false);
			maintenez.SetActive(true);
		}

		public void ReturnAppuyer ()
		{

			button.Play();
			appuyez.SetActive(true);
			maintenez.SetActive(false);
		}


		public void GoToGLissez ()
		{
			button.Play();
			maintenez.SetActive(false);
			glissez.SetActive(true);
		}

		public void ReturnMaintenez ()
		{
			button.Play();
			maintenez.SetActive(true);
			glissez.SetActive(false);
		}

		public void GoToRelachez ()
		{
			button.Play();
			glissez.SetActive(false);
			relachez.SetActive(true);
		}

		public void ReturnGlissez ()
		{
			button.Play();
			relachez.SetActive(false);
			glissez.SetActive(true);
		}

		public void GoToTimer()
		{
			button.Play();
			relachez.SetActive(false);
			tutotimer.SetActive(true);
		}
		
		public void ReturnRelachez ()
		{
			button.Play();
			tutotimer.SetActive(false);
			relachez.SetActive(true);
		}

		public void LoadKevin ()
		{
		button.Play();
		 SceneManager.LoadScene("SceneKevin");
		}

}
