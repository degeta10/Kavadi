using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowDie : MonoBehaviour {

	public Transform[] cases;
	public Transform[] pawn1;
	public Transform[] pawn2;
	public Button Add, Move;
	public int npawns=6;

	private int[] flag;
	private int dnumber;
	private int choice;
	private int k=0;

	void Start () 
	{
		//npawns = 6;
		Add.gameObject.SetActive(false);
		Move.gameObject.SetActive(false);
	}
	public void Die_Throw()
	{
		Debug.Log ("Die_Throw is called");
		if (npawns > 0) 
		{
			int dienumber = Random.Range (1, 7);
			Debug.Log ("Die number= "+dienumber+" Npawns ="+npawns);
			if (dienumber == 1 & npawns <= 6)
			{
				if (npawns == 6)
				{
					Debug.Log ("equals 1 but npawns=6");
					SpawnAtZero (5, npawns-1);
				}
				if (npawns <= 5)
				{
					Debug.Log ("equals 1 but npawns<6");
					int ch=0;
					//Clik ();
					dnumber = dienumber;
					if(ch==1)
						Moveposition (dnumber);
					else
						SpawnAtZero (npawns-1,npawns-1);
				}
				npawns = npawns - 1;
				ChangePlayer ();
			} 
			else if (dienumber == 6 & npawns == 6) 
			{
				Debug.Log ("equals 6");
				npawns = 0;
				SpawnAtZero (5,npawns);
				ChangePlayer ();
			}
			else if (npawns<6) 
			{
				Debug.Log ("less than 6");
				dnumber = dienumber;
				Moveposition (dnumber);
				ChangePlayer();
			}
		} 
		else
		{
			Debug.Log ("npawns is zero");
			//In this case all the pawns are on the board.
			//So we can just roll the die and move our desired pawns on the board.
		}		
	}

	public void Moveposition(int dnum)
	{
		Debug.Log ("Moveposition function called");
		int kpawns = 6 - npawns;
		int d = dnum;
		if (kpawns >= 1) 
		{
			MovablePawns (dnum,kpawns);
			//Select pawns for movable pawns
			//Sposition=Sposition+d;
		}
		ChangePlayer ();

	}

	public void ChangePlayer()
	{
		Debug.Log ("ChangePlayer function called");
	}

	public int Choice(int i)
	{
		Debug.Log ("Choice function called");
		Add.gameObject.SetActive(true);
		Move.gameObject.SetActive(true);
		if(i==1)
		{
			choice = 1;
			Debug.Log ("Choice 1 picked");
			return choice;
		}
		else if (i==2)
		{
			choice = 2;
			Debug.Log ("Choice 2 picked");
			return choice;
		}
		return choice;
	}
	public void Clik(int i)
	{
		Choice (i);
	}

	public void MovablePawns(int dnum,int kp)
	{
		Vector3 dist = cases [0].transform.position-cases[1].transform.position;
		for(int i=1;i<=kp;i++)
		{
			if (dnum > 0)
			{
				Vector3 currentpos = pawn1 [6 - i].transform.position;
				Vector3 nextpos = pawn1 [6 - i].transform.position+dist;
				Vector3 distance = nextpos - currentpos;


			}
			
		}
	}

	public void SpawnAtZero(int index,int numberofpawns)
	{	
		Debug.Log ("Spawn function called !");	

		for(int i=index;i>=numberofpawns;i--)
		{
			Vector3 spawnpos=cases[0].transform.position;//No matter what our pawn enters the first position only
			Debug.Log ("Loop Finished"+i);		
			Instantiate (pawn1[i],spawnpos,Quaternion.identity);
			Debug.Log ("Spawned "+i+" th pawn");
		}
	}

	void Update () {

	}
}
