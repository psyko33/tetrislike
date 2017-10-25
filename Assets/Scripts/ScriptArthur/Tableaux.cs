
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tableaux : MonoBehaviour {


	public GameObject[] tableauxIdx;
	private int nombreIdx;
	private GameObject currentWall;
	private int currentHoles;
	private int currentscore;
	private float currentTimer;
	public float baseTimer;
	public Text scoreText;
	public Text timerText;
	public GameObject uiManager;
	public Text scoreFinal;
	public Button boutonAddTimer;
	private bool canBuy = true;
	



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
		PopMur();
		currentTimer = baseTimer;
		

	}
	void Update()
	{
		TimerCD();
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
		if(currentHoles == 0)
		{	
			AddScore();
			UpdateWall();
		}
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
			UIManager.Instance().Timer();
			scoreFinal.text=currentscore.ToString ("");
		}
	}


	public void BoutiqueAddTimer()
	{
		if(canBuy == true)
		{
		currentTimer+=10f;
		timerText.text = currentTimer.ToString("f0");
		canBuy = false ;
		}
	 
	}

	
}


	
	

	

