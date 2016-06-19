using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10);
	}
}
