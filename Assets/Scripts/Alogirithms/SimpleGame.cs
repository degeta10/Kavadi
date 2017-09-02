using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleGame : MonoBehaviour {

	public Transform[] casesof1;
	public Transform[] casesof2;
	public Transform pawn1;
	public Transform pawn2;
	public Button player1, player2;

	private int npawns1;
	private int npawns2;
	private int currentposof1;
	private int currentposof2;

	void Awake()
	{
		npawns1 = 0;
		currentposof1 = 0;
		Vector3 pos1 = casesof1 [0].transform.position;
		pawn1.transform.position = pos1;
		Debug.Log ("placed player 1 in initial position");

		npawns2 = 0;
		currentposof2 = 0;
		Vector3 pos2 = casesof2 [0].transform.position;
		pawn2.transform.position = pos2;
		Debug.Log ("placed player 2 in initial position");
	}

	void Start ()
	{
		player1.gameObject.SetActive (true);
		player2.gameObject.SetActive (false);
	}

	public void DeiThrow1()
	{
		Debug.Log ("Die_Throw is called");
		if (npawns1 == 0)
		{
			int dienumber = Random.Range (1, 1);
			Debug.Log ("Die number= " + dienumber);
			Spawn1 (dienumber);
		}
		player1.gameObject.SetActive (false);
		player2.gameObject.SetActive (true);
	}

	public void DeiThrow2()
	{
		Debug.Log ("Die_Throw is called");
		if (npawns2 == 0) 
		{
			int dienumber = Random.Range (1, 1);
			Debug.Log ("Die number= "+dienumber);
			Spawn2 (dienumber);					
		}
		player1.gameObject.SetActive (true);
		player2.gameObject.SetActive (false);
	}

	void Spawn1(int dienumber)
	{		
		if (currentposof1 == 0 /*&& dienumber == 1 && dienumber == 6*/) 
		{
			currentposof1 = currentposof1 + 1;
			pawn1.transform.position = casesof1 [currentposof1].transform.position;
		} 
		else
			if(currentposof1>=1)
			{
				currentposof1 = currentposof1 + dienumber;
				Vector3 spawnpos=casesof1[currentposof1].transform.position;
					if (spawnpos == pawn2.transform.position)
					{
						pawn2.transform.position = casesof2 [0].transform.position;
						currentposof2 = 0;
						pawn1.transform.position = spawnpos;
					} 
					else
					{
						pawn1.transform.position = spawnpos;
					}
				Debug.Log ("Spawn1 called");
			}
	}

	void Spawn2(int dienumber)
	{
		if (currentposof2 == 0 /*&& dienumber == 1 && dienumber == 6*/)
		{
			currentposof2 = currentposof2 + 1;
			pawn2.transform.position = casesof2 [currentposof2].transform.position;
		} 
		else
			if(currentposof2>=1)
			{
				currentposof2 = currentposof2 + dienumber;
				Vector3 spawnpos = casesof2 [currentposof2].transform.position;
					if (spawnpos == pawn1.transform.position) 
					{
						pawn1.transform.position = casesof1 [0].transform.position;
						currentposof1 = 0;
						pawn2.transform.position = spawnpos;
					}
					else
					{
						pawn2.transform.position = spawnpos;
					}
				Debug.Log ("Spawn2 called");
			}
	}	

	void Update () 
	{
		
	}
}
