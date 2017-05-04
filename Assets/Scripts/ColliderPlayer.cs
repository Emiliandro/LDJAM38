using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderPlayer : MonoBehaviour {

	public string prxScene;
	// Use this for initialization
	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Finish") {
			ReloadScene ();
		}
		if (other.gameObject.tag == "Next") {
			CarregarCena (prxScene);
		}
	}
	
	void ReloadScene () {
		Scene valor = SceneManager.GetActiveScene ();
		CarregarCena (valor.name);
	}

	void CarregarCena(string valor){
		SceneManager.LoadScene (valor);
	}
}
