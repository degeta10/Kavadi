using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationScript : MonoBehaviour {

	private Animator anim=null;

	void Start () {		
	}

	public void AnimateOnPress()
	{	
		if (Input.GetKeyDown (KeyCode.W))
		{
			anim.Play ("Rotate_Up");
		}
		else if (Input.GetKeyDown (KeyCode.S))
		{
			anim.Play ("Rotate_Down");
		}
		else if (Input.GetKeyDown (KeyCode.A))
		{
			anim.Play ("Rotate_Left");
		}
		else if (Input.GetKeyDown (KeyCode.D))
		{
			anim.Play ("Rotate_Right");
		}
		else if(Input.GetKeyUp (KeyCode.D)||Input.GetKeyUp (KeyCode.W)||Input.GetKeyUp (KeyCode.S)||Input.GetKeyUp (KeyCode.A))
		{
			anim.Play ("Idle");
		}
	}

	 void Update ()
	{
		AnimateOnPress ();
	}
}
