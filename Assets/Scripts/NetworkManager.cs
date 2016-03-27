using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {


	void Start () {
		PhotonNetwork.ConnectUsingSettings ("1.0");

	}

	void OnConnectedToMaster(){
		RoomOptions roomOptions = new RoomOptions () {isVisible = true,
			maxPlayers = 20,
			cleanupCacheOnLeave = true
		};
		PhotonNetwork.JoinOrCreateRoom ("TheTheaterRoom", roomOptions, TypedLobby.Default);
	}

	void OnJoinedRoom(){
		Transform t = GameObject.Find ("SpawnPoint").transform;
		GameObject newPlayer = PhotonNetwork.Instantiate ("Cube", t.position, t.rotation, 0);

	}
		







}
