using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;


public class HoloFireHose : MonoBehaviour, IInputClickHandler{

	public ParticleSystem water;
	public GameObject waterCol;
	public AudioSource waterSound;
	GesturesInput gesture;
	Coroutine waterCo;
	// Use this for initialization

	public void Start(){
		waterCol.SetActive (false);
		water.Stop ();
		//gesture.RecognizerStart ();
	}

//	void OnEnable(){
//		gesture.
//	}

	public void OnInputClicked(InputClickedEventData eventData){
		Debug.Log ("Input clicked");
		ShootHose ();
	}

	public void ShootHose(){

		Debug.Log ("Shoot hose");
		if (waterCo != null) {
			StopCoroutine (waterCo);
			waterCo = StartCoroutine (MomentaryHose ());
		} else if (waterCo == null) {
			waterCo = StartCoroutine (MomentaryHose ());
		}

	}


	IEnumerator MomentaryHose(){
		Debug.Log ("momentary hose");
			
		water.Play ();
		waterSound.Play ();
		waterCol.SetActive (true);
		yield return new WaitForSeconds (1.0f);
		water.Stop ();
		waterSound.Stop ();
		waterCol.SetActive (false);
	}
}
