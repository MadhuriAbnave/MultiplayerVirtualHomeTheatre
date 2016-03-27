using UnityEngine;
using System.Collections;

public class PlayMovieOnSpace : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Renderer r = GetComponent<Renderer> ();
		MovieTexture movie = (MovieTexture)r.material.mainTexture;
		//AudioSource aud = GetComponentInChildren<AudioSource>();
		//aud.clip = movie.audioClip;
		movie.Play();
		//aud.Play();

			

	}

}