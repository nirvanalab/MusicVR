using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VideoController : MonoBehaviour {

	public UnityEngine.Video.VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayVideo() {
		videoPlayer.Play ();
	}

	public void PauseVideo() {
		videoPlayer.Pause();
	}

	public void StopVideo() {
		videoPlayer.Stop ();
	}

}
