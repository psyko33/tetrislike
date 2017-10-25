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

		public void GoToAppuyez ()
		{
			 background.SetActive(false);
			 popuptuto.SetActive(false);
			 appuyez.SetActive(true);
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

		public void GoToTimer()
		{
			relachez.SetActive(false);
			tutotimer.SetActive(true);
		}
		
		public void ReturnRelachez ()
		{
			tutotimer.SetActive(false);
			relachez.SetActive(true);
		}

		public void LoadKevin ()
		{
		 SceneManager.LoadScene("SceneKevin");
		}

}
