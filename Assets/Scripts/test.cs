using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	private int npawns=0;
	private int random=0;
	private int cumulative=0;
	private int maxcases=28;

	public Transform[] cases;
	public Transform pawn;

	void Start () 
	{	
	}

	public void mainfunc()
	{
		random = Random.Range (1, 7);	
		if (cumulative+random <25) {
			switch (random) {
			case 1:
				cumulative += random;
				Spawn ();	
				break;
			case 2:
				cumulative += random;
				Spawn ();			
				break;
			case 3:
				cumulative += random;
				Spawn ();			
				break;
			case 4:
				cumulative += random;
				Spawn ();			
				break;
			case 5:
				cumulative += random;
				Spawn ();			
				break;
			case 6:
				cumulative += random;
				Spawn ();			
				break;
			}
		}
	}

	void Spawn()
	{		
		Vector3 spawn=cases[cumulative].transform.position;
		pawn.transform.position=spawn;
	}	

	void Update ()
	{
			
	}
}
