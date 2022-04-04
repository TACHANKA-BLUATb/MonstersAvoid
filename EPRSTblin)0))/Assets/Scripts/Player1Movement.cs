using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {
[SerializeField]
protected float MoveForce = 5f;
[SerializeField]
protected float JumpForce = 11f;
protected float MovementX;
protected string JUMP_ANIMATION1 = "Jump1";
protected Rigidbody2D myBody;
protected Animator anim;
protected Transform player1;
protected string WALK_ANIMATION1 = "Walk1";
protected bool isGrounded = true;
protected string GROUND_TAG = "Ground";

void Start () {
	player1 = GameObject.FindWithTag("Player 1").transform;
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
	if (player1.position.y > 0.4){
		anim.SetBool(WALK_ANIMATION1, false);
		anim.SetBool(JUMP_ANIMATION1, true);
	}else if  (player1.position.y < 0.4){
		anim.SetBool(JUMP_ANIMATION1, false);
 		if (MovementX != 0){
 			anim.SetBool(WALK_ANIMATION1, true);
		}else {
 	 		anim.SetBool(WALK_ANIMATION1, false);
 		}
	}
}
protected void RotatePlayer(){
	if (MovementX > 0){
		player1.localScale = new Vector3(0.7f, 0.7f, 1f);
	} else if (MovementX < 0){
		player1.localScale = new Vector3(-0.7f, 0.7f, 1f);
	}
}
}
