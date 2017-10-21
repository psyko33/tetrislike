
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableaux : MonoBehaviour {


	public GameObject[] tableauxIdx;
	private int nombreIdx;
	private GameObject currentWall;
	private int currentHoles;

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
			UpdateWall();

		}
	}

	

	

}