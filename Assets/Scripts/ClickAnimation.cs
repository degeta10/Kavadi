using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAnimation : MonoBehaviour {

	public Animator anim;

	private int random=0;
	private bool click=false;

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
		random = Random.Range (1, 5);
		if (click)
		{
			switch (random) {
			case 1:
				anim.Play ("Rotate_Up");
				break;
			case 2:
				anim.Play ("Rotate_Down");
				break;
			case 3:
				anim.Play ("Rotate_Left");
				break;
			case 4:
				anim.Play ("Rotate_Right");
				break;
			}
		} 
		else
		{
			anim.Play ("Idle");
		}
	}

	void Update (){		
	}
}
