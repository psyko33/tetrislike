
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
		if(nombreIdx == 21)
		{
			Debug.Log("fini");
		}
		else if (nombreIdx != 21)
		{
			nombreIdx ++;
			PopMur();
		}	
	}

	public void CheckWin()
	{
		currentHoles--;
		if(currentHoles == 0)
		{
			AddTimer();
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
		
		currentTimer+=5f;
		timerText.text = currentTimer.ToString("f0");
	}

	void TimerCD()
	{
		currentTimer -= Time.deltaTime;
		timerText.text = currentTimer.ToString("f0");

		if(currentTimer <= 0.0f)
		{
			UIManager.Instance().Timer();
		}
	}

	
}


	
	

	

