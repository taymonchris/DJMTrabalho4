using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

	// Use this for initialization
	public GameObject gameOverPanel;

	void Start () {
		//gameOverPanel = GameObject.Find ("GameOverPanel");
	}
	public void activeGameOverPanel(){
		gameOverPanel.SetActive (true);
	}
	public void deactivateGameOverPanel(){
		gameOverPanel.SetActive (false);
	}
}
