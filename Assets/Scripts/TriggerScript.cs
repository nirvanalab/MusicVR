using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnEnter() {
		Debug.Log ("OnEnter");
	}

	public void OnExit() {
		Debug.Log ("OnExit");
	}

	public void OnClick() {
		iTween.MoveTo (player, new Vector3(transform.position.x,transform.position.y,transform.position.z), 5f);
		GetComponent<MeshRenderer>().enabled = false;
		//player.transform.position = transform.position;
	}
}
