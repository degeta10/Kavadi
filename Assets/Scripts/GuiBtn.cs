using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiBtn : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//OnGUI ();
	}

	void OnGUI()
	{		
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2,60,30),"Click"))
		{
			Debug.Log ("Clicked the Button");
		}
	}

	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
