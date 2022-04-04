using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {
[SerializeField]
protected float MoveForce = 5f;
[SerializeField]
protected float JumpForce = 11f;
protected float MovementX;
protected string JUMP_ANIMATION21 = "Jump1";
protected string JUMP_ANIMATION22 = "Jump2";
protected Rigidbody2D myBody;
protected Animator anim;
protected Transform player2;
protected string WALK_ANIMATION2 = "Walk";
protected bool isGrounded = true;
protected string GROUND_TAG = "Ground";

void Start () {
	player2 = GameObject.FindWithTag("Player 2").transform;
}

public void Awake(){
	myBody = GetComponent<Rigidbody2D>();
	anim = GetComponent<Animator>();
}

void Update () {
	PlayerMoveKeyboard();
	PlayerJump();
	AnimatePlayer();
	RotatePlayer();
}
	
protected void PlayerMoveKeyboard(){
	MovementX = Input.GetAxisRaw("Horizontal");
	transform.position += new Vector3(MovementX, 0, 0) * Time.deltaTime * MoveForce;
}

protected void OnCollisionEnter2D(Collision2D collision){
	if (collision.gameObject.CompareTag(GROUND_TAG)){
		isGrounded = true;
	}
}

protected void PlayerJump(){
	if(Input.GetButtonDown("Jump") && (isGrounded == true)){
		isGrounded = false;
	    myBody.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
	}
}	

protected void AnimatePlayer(){
	if (myBody.velocity.y > 0.2){
		anim.SetBool(WALK_ANIMATION2, false);
		anim.SetBool(JUMP_ANIMATION21, true);
	}else if (myBody.velocity.y <-0.2){
		anim.SetBool(WALK_ANIMATION2, false);
		anim.SetBool(JUMP_ANIMATION22, true);
	}else if (MovementX != 0){
		anim.SetBool(JUMP_ANIMATION21, false);
		anim.SetBool(JUMP_ANIMATION22, false);
		anim.SetBool(WALK_ANIMATION2, true);
	}else {
		anim.SetBool(JUMP_ANIMATION21, false);
		anim.SetBool(JUMP_ANIMATION22, false);
		anim.SetBool(WALK_ANIMATION2, false);
	}
}
protected void RotatePlayer(){
	if (MovementX > 0){
		player2.localScale = new Vector3(1.8f, 1.8f, 1f);
	} else if (MovementX < 0){
		player2.localScale = new Vector3(-1.8f, 1.8f, 1f);
	}
}
}
