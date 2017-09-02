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
			int dienumber = Random.Range (1, 7);
			Debug.Log ("Die number= " + dienumber);

			currentposof1 = currentposof1 + dienumber;
			Debug.Log ("currentpos1 = " + currentposof1);
			Spawn1 (currentposof1);
		}
		player1.gameObject.SetActive (false);
		player2.gameObject.SetActive (true);
	}

	public void DeiThrow2()
	{
		Debug.Log ("Die_Throw is called");
		if (npawns2 == 0) 
		{
			int dienumber = Random.Range (1, 7);
			Debug.Log ("Die number= "+dienumber);

			currentposof2 = currentposof2 + dienumber;
			Debug.Log ("currentpos2 = "+currentposof2);
			Spawn2 (currentposof2);			
		}
		player1.gameObject.SetActive (true);
		player2.gameObject.SetActive (false);
	}

	void Spawn1(int index)
	{
		Vector3 spawnpos=casesof1[index].transform.position;

		pawn1.transform.position=spawnpos;
		Debug.Log ("Spawn1 called" );
	}

	void Spawn2(int index)
	{
		Vector3 spawnpos=casesof2[index].transform.position;

		pawn2.transform.position=spawnpos;
		Debug.Log ("Spawn2 called" );
	}	

	void Update () 
	{
		
	}
}
