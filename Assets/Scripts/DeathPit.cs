using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPit : MonoBehaviour {
    Scene cena;
    private void Start()
    {
        //cena = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            //SceneManager.LoadScene(cena.buildIndex);
			other.GetComponent<PlayerBehaviour> ().Die ();
		}
    }
}
