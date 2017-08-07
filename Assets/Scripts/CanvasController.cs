using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {


	public GameObject screen;
	public GameObject exit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showScreen() {
		screen.SetActive (true);
		exit.SetActive (false);
	}

	public void hideScreen() {
		screen.SetActive (false);
		exit.SetActive (true);
	}



}
