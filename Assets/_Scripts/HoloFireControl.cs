using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloFireControl : MonoBehaviour {

	public TextMesh textM;

	public int fires=0;
	int m_Fire{
		get { return fires; } 
		set {fires = value;
			textM.text = "Fires Left : " + fires.ToString ();
			if (fires == 0) {
				WinGame ();
			}
		}}

	public void WinGame(){
		Debug.Log ("Congrats you won");
		textM.text = "All fires out! You won!";
	}

	public void IgniteFire(){
		m_Fire++;
	}

	public void PutOutFire(){
		m_Fire--;
	}


}
