using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJouerQuitter : MonoBehaviour 
{


	public void OnClickStart ()
	{
	 Application.LoadLevel("SceneLobby");	
	}
	
	public void OnClickStart2 ()
	{
	 Application.LoadLevel("SceneMikael");	
	}
	

	public void QuitButton()
	{
		Application.Quit() ;
	}

}
