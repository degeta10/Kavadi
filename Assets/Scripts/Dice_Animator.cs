using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Animator : MonoBehaviour {

	public Animator anim;

	private int random=0;
	private bool click=false;

	// Use this for initialization
	void Start () {
		
	}
	public void OnClick()
	{
		click = true;
	}

	public void OffClick()
	{
		click = false;
	}
	public void Rotation()
	{
		random = Random.Range (1, 7);
		if (click)
		{
			switch (random) {
			case 1:
				anim.Play ("Dice_1");
				break;
			case 2:
				anim.Play ("Dice_2");
				break;
			case 3:
				anim.Play ("Dice_3");
				break;
			case 4:
				anim.Play ("Dice_4");
				break;
			case 5:
				anim.Play ("Dice_5");
				break;
			case 6:
				anim.Play ("Dice_6");
				break;
			}
		} 
		else
		{
			anim.Play ("Dice_Idle");
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
