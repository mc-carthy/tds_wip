using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 5f;

	Vector3 mousePos;
	Vector3 velocity;
	Rigidbody2D rigidBody;
	Controller2D controller;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		controller = GetComponent<Controller2D> ();
	}
	
	void Update () {
		//LookAtCursor ();
		Move ();
	}

	void LookAtCursor() {
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

	void Move() {
		Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));


		velocity.x = input.x * moveSpeed;
		velocity.y = input.y * moveSpeed;
		controller.Move (velocity * Time.deltaTime);
	}


}
