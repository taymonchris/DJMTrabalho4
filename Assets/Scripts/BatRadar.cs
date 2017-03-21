using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatRadar : MonoBehaviour {



	private MorcegoIA script;


	// Use this for initialization
	void Start () {
		script = (MorcegoIA)GetComponentInParent (typeof(MorcegoIA));
	}

	void onTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player") {
			script.lostPlayer = false;
			script.canFly = true;
			
		}


	}


	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Player") {
			script.BackToHome ();
			script.lostPlayer = true;
			script.canFly = true;

		}
	
	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
