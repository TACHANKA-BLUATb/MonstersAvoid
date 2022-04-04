using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour {
[SerializeField]
protected float speed;
private Rigidbody2D myBody;
	void Awake () {
		myBody = GetComponent<Rigidbody2D>();

		speed = 4;
	}
		void FixedUpdate () {
		myBody.velocity = new Vector2(speed, myBody.velocity.y);
	}
}
