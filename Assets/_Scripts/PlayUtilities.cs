using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayUtilities : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart(){
		SceneManager.LoadScene ("Main");
	}

	public void Quit(){
		Application.Quit ();
	}

}
