﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public float autoLoadNextLevelAfter;

	void Start(){
		if (autoLoadNextLevelAfter == 0) {
			Debug.Log ("Auto load disabled.");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}

	}
	public void LoadLevel(string name){
		Debug.Log ("Level load requested for:" + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest(){
		Debug.Log ("I want to quit.");
		Application.Quit ();
	}

	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}