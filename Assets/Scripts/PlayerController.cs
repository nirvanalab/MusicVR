using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject startPoint;
	public GameObject viewPoint;
	public GameObject player;
	public GameObject entryCanvas;
	public GameObject exitCanvas;

	public void goToStartPoint(){
		exitCanvas.SetActive (false);
		iTween.MoveTo (player, startPoint.transform.position, 5f);
		entryCanvas.SetActive (true);
	}

	public void goToViewPoint(){
		entryCanvas.SetActive (false);
		iTween.MoveTo (player, viewPoint.transform.position, 5f);
		exitCanvas.SetActive (true);
	}


		
}
