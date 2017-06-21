using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class HoloFire : MonoBehaviour , IInputClickHandler {

	public bool onFire = false;
	ParticleSystem particle;
	HoloFireControl fireControl;

	// Use this for initialization
	void Start () {
		particle = GetComponent<ParticleSystem> ();
		particle.Play ();
		onFire = true;
		fireControl = GameObject.FindGameObjectWithTag ("GameController").GetComponent<HoloFireControl> ();
		fireControl.IgniteFire ();
	}

	public void OnInputClicked(InputClickedEventData eventData){

		PutOutFire ();
	}

	void PutOutFire(){
		GetComponent<BoxCollider> ().enabled = false;
		particle.Stop ();
		onFire = false;
		fireControl.PutOutFire ();
		Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Water") {
			PutOutFire ();
		}
	}
}
