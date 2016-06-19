using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 5f;

	Vector3 mousePos;
	Rigidbody2D rigidBody;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
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
		float xMove = Input.GetAxisRaw ("Horizontal");
		float yMove = Input.GetAxisRaw ("Vertical");

		Vector3 velocity = new Vector3 (xMove, yMove).normalized;

		transform.position += velocity * moveSpeed * Time.deltaTime;
	}
}
