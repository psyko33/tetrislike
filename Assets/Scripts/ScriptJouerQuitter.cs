using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJouerQuitter : MonoBehaviour 
{
	public GameObject boutique;
	public GameObject lobby;


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
	lobby.SetActive(false);

	}
	public void LoadLobby ()
	{
	boutique.SetActive(false);
	lobby.SetActive(true);

	}

	public void QuitButton()
	{
		Application.Quit() ;
	}

}
