using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCodeManager : MonoBehaviour {

	public Sprite red, white, blue;
	public SpriteRenderer manager;

	public Collider2D[] redInPhase;
	public Collider2D[] blueInPhase;

	// Use this for initialization
	void Start () {
		SpriteChanger (white);
		ColliderManager (white);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Z)) {
			SpriteChanger (white);
			ColliderManager (white);
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			SpriteChanger (red);
			ColliderManager (red);
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			SpriteChanger (blue);
			ColliderManager (blue);
		}
	}

	void SpriteChanger(Sprite valor){
		manager.sprite = valor;
	}

	void ColliderManager(Sprite valor){

		if (valor == red) {
			foreach (Collider2D tangibilidade in blueInPhase) {
				tangibilidade.enabled = false;
			}

			foreach (Collider2D tangibilidade in redInPhase) {
				tangibilidade.enabled = true;
			}
		}

		if (valor == white) {
			foreach (Collider2D tangibilidade in redInPhase) {
				tangibilidade.enabled = false;
			}

			foreach (Collider2D tangibilidade in blueInPhase) {
				tangibilidade.enabled = false;
			}
		}

		if (valor == blue) {
			foreach (Collider2D tangibilidade in blueInPhase) {
				tangibilidade.enabled = true;
			}

			foreach (Collider2D tangibilidade in redInPhase) {
				tangibilidade.enabled = false;
			}
		} 

	}
}
