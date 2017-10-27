
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tableaux : MonoBehaviour {


	public GameObject[] tableauxIdx;
	private int nombreIdx;
	public int nbSkipLvl;
	private int nbAudio;
	private GameObject currentWall;
	private int currentHoles;
	private int currentscore;
	private float currentTimer;
	public float baseTimer;
	public Text scoreText;
	public Text timerText;
	public GameObject uiManager;
	public Text scoreFinal;
	public ParticleSystem confeti1;
	public ParticleSystem confeti2;
	public AudioSource confettiAudio;
	public AudioSource achatGemmes;
	public AudioSource bouton;
	public AudioSource correctforme;
	public AudioSource drag;
	public AudioSource timesUp;
	private bool audioOnce = false; 

	private int nbGemmes = 0;
	public Text gemmes;
	public Text gemmes2;

	



    private static Tableaux instance;
    public static Tableaux Instance () 
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



	// Use this for initialization
	void Start () 
	{
		nombreIdx = 0;
		nbSkipLvl = 2;
		nbAudio = 1;
		PopMur();
		currentTimer = baseTimer;
		

	}
	void Update()
	{
		TimerCD();

		if(audioOnce == true && nbAudio >= 0)
		{
			nbAudio --;
			timesUp.Play();
			audioOnce = false;
		}

	}
	
	void PopMur()
	{
		currentWall = Instantiate(tableauxIdx[nombreIdx],transform.position,transform.rotation);
		currentHoles = currentWall.GetComponent<Murs>().GetNumHoles();
	
	}
			

	void UpdateWall()
	{
		Destroy(currentWall);
		if(nombreIdx == 19)
		{
			uiManager.GetComponent<UIManager>().TimerWin();
		}
		else if (nombreIdx != 19)
		{
			AddTimer();
			nombreIdx ++;
			PopMur();
		}	
	}

	public void CheckWin()
	{
		currentHoles--;
		correctforme.Play();
		if(currentHoles == 0)
		{	
			StartCoroutine(Wait());
		}
	}

	IEnumerator Wait()
	{
		confettiAudio.Play();
		confeti1.Play();
		confeti2.Play();
		yield return new WaitForSeconds(1);
		AddScore();
		UpdateWall();
	}

	void AddScore()
	{
		currentscore += currentWall.GetComponent<Murs>().GetScoreMurs();
		scoreText.text=currentscore.ToString ("");
	}

	 void AddTimer()
	{
		
		currentTimer+=10f;
		timerText.text = currentTimer.ToString("f0");
	}
	void TimerCD()
	{
		currentTimer -= Time.deltaTime;
		timerText.text = currentTimer.ToString("f0");

		if(currentTimer <= 0.0f)
		{
			audioOnce = true;
			UIManager.Instance().Timer();
			scoreFinal.text=currentscore.ToString ("");
		}
	}


	public void BoutiqueAddTimer()
	{
		if (nbGemmes>=50)
		{
		bouton.Play();
		currentTimer+=10f;
		timerText.text = currentTimer.ToString("f0");
		nbGemmes-=50;
		gemmes.text = nbGemmes.ToString("");
		gemmes2.text = nbGemmes.ToString("");
		}
	}
	 
	public void BoutiqueSkip1Level()
	{
		if(nbGemmes>=100 && nombreIdx < 19)
		{
			if (nbSkipLvl >= 0)
			{
				nbSkipLvl --;
				bouton.Play();
				nombreIdx++;
				nbGemmes-=100;
				Destroy(currentWall);
				PopMur();
				gemmes.text = nbGemmes.ToString("");
				gemmes2.text = nbGemmes.ToString("");
			}	
		}
	}

	public void Add100()
	{
		nbGemmes+=100;
		achatGemmes.Play();
		gemmes.text = nbGemmes.ToString("");
		gemmes2.text = nbGemmes.ToString("");

	}
	public void Add600()
	{
		nbGemmes+=600;
		achatGemmes.Play();
		gemmes.text = nbGemmes.ToString("");
		gemmes2.text = nbGemmes.ToString("");
	}

	public void PlaySoundOnClick()
	{
		drag.Play();
	}



	
}