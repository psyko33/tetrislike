using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJouerQuitter : MonoBehaviour 
{
	public GameObject boutique;
	public GameObject jouer;


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
	jouer.SetActive(false);

	}
	public void LoadJouer ()
	{
	boutique.SetActive(false);
	jouer.SetActive(true);

	}

	public void QuitButton()
	{
		Application.Quit() ;
	}

}
