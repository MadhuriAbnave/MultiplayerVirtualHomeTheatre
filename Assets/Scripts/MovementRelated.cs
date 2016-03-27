using UnityEngine;
using System.Collections;

public class MovementRelated : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion gazeDirection = gameObject.GetComponentInChildren<Camera> ().transform.localRotation;
		Debug.Log (gazeDirection.ToString ());
		gameObject.transform.localRotation = gazeDirection;
	}
}
