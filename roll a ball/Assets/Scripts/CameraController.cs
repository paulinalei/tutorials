using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // want camera to be at a certain distance from player at each frame
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    // LateUpdate is guaranteed to run
	void LateUpdate () {
        // update camera so that it will be aligned with the player object even when player moves
        transform.position = player.transform.position + offset;
	}
}
