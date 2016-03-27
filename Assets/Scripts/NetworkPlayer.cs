﻿using UnityEngine;
using System.Collections;

public class NetworkPlayer : Photon.MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (photonView.isMine) {
			gameObject.GetComponentInChildren<Camera> ().enabled = true;
			gameObject.GetComponentInChildren<AudioListener>().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
