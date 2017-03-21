using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //Canvas canvas;
    GameObject player;

	// Use this for initialization
	void Start () {
        //canvas = gameObject.GetComponent<Canvas>();
        player = GameObject.FindGameObjectWithTag("Player");
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text =Mathf.Floor(player.transform.position.x).ToString();
	}
}
