using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorcegoIA : MonoBehaviour {


	public Transform batHome;
	private Transform player;
	private Vector3 positionPlayerLost;
	private Vector3 positionPlayerFind;
	private Transform bat;

	public float speed;
	private float starTime;
	private float journeyLenght;

	public bool lostPlayer = true;
	public bool canFly = false;

	// Use this for initialization
		void Start () {

		bat = GetComponent<Transform>();
		batHome = bat.transform.parent;
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		positionPlayerLost = batHome.position;
		BackToHome ();


		
	}
	
	// Update is called once per frame
	void Update () {

		if (canFly)
			if (lostPlayer) {
			
			float dist = (Time.time - starTime) * speed;
			float journey = dist / journeyLenght;

			if (bat.position == batHome.position)
				canFly = false;

			bat.position = Vector3.Lerp (positionPlayerLost, batHome.position, journey);
		} 

		else {
			bat.position = Vector3.Lerp (bat.position, player.position, 0.05f);

		}


	}

		public void BackToHome(){
        starTime = Time.time ;
		positionPlayerLost = bat.position;
		journeyLenght = Vector3.Distance (positionPlayerLost, batHome.position);

	}

		void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "Player"){
			lostPlayer = false;

			Debug.Log("Player perdeu vida!");
		}
	}



}
