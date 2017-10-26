using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioLobby : MonoBehaviour {

	public AudioClip musicMenu,musicJeu;
	public string nomScene,sceneDebut;
	private AudioSource audioSourceComponent;

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}
	// Use this for initialization
	void Start () {
		audioSourceComponent = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if(SceneManager.GetActiveScene().name == sceneDebut && audioSourceComponent.clip == musicJeu)
		{
			audioSourceComponent.Stop();
			audioSourceComponent.clip = musicMenu;
			audioSourceComponent.Play();
		}
		else if(SceneManager.GetActiveScene().name == nomScene && audioSourceComponent.clip == musicMenu)
		{
			audioSourceComponent.Stop();
			audioSourceComponent.clip = musicJeu;
			audioSourceComponent.Play();
		}
	}
}
