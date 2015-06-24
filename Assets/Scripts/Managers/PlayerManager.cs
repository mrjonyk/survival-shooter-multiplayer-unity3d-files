﻿using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
	public float respawnDelay = 2f;

	void OnJoinedRoom ()
	{
		InstantiatePlayer ();
	}

	void InstantiatePlayer ()
	{
		PositionData randomPosition = PositionHelper.GetRandomSpawnPosition ();
		GameObject player = PhotonNetwork.Instantiate ("Player", Vector3.zero, Quaternion.identity, 0);
		player.GetComponent<AudioListener> ().enabled = true;
		GameObjectHelper.SendMessageToAll ("OnPlayerInstantiated", player);
	}
}