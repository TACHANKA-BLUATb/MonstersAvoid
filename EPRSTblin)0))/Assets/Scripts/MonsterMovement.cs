﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour {
[SerializeField]
public float speed;
private Rigidbody2D myBody;
	void Awake () {
		myBody = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate () {
		myBody.velocity = new Vector2(speed, myBody.velocity.y);
	}
}
