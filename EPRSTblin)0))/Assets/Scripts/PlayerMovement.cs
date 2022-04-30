using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

protected Rigidbody2D myBody;
protected Animator anim;
protected Transform player;
private bool isGrounded = true;
private Vector3 TempPos;

void Start ()
{
	player = GameObject.FindWithTag(GameConstants.PLAYER_TAG).transform;
}

public void Awake()
{
	myBody = GetComponent<Rigidbody2D>();
	anim = GetComponent<Animator>();
}

void Update ()
{
	PlayerMoveKeyboard();
	PlayerJump();
	AnimatePlayer();
	RotatePlayer();
	CoordinatesLimit();
}
	
protected void PlayerMoveKeyboard()
{
	GameConstants.MovementX = Input.GetAxisRaw("Horizontal");
	transform.position += new Vector3(GameConstants.MovementX, 0, 0) * Time.deltaTime * GameConstants.MoveForce;
}

protected void OnCollisionEnter2D(Collision2D collision)
{
	if (collision.gameObject.CompareTag(GameConstants.GROUND_TAG))
	{
		isGrounded = true;
	}
	if (collision.gameObject.CompareTag(GameConstants.ENEMY_TAG))
	{
		Destroy(gameObject);
	}
}

private void OnTriggerEnter2D(Collider2D collision)
{
	if (collision.CompareTag(GameConstants.ENEMY_TAG))
	{
	Destroy(gameObject);
	}
}

protected void PlayerJump()
{
	if(Input.GetButtonDown("Jump") && (isGrounded == true))
	{
		isGrounded = false;
	    myBody.AddForce(new Vector2(0f, GameConstants.JumpForce), ForceMode2D.Impulse);
	}
}	

protected void AnimatePlayer()
{
	if (myBody.velocity.y > 0.2)
	{
		anim.SetBool(GameConstants.WALK_ANIMATION, false);
		anim.SetBool(GameConstants.JUMP_ANIMATION1, true);
	}
	else 
	if (myBody.velocity.y <-0.2)
	{
		anim.SetBool(GameConstants.WALK_ANIMATION, false);
		anim.SetBool(GameConstants.JUMP_ANIMATION2, true);
	}
	else 
	if (GameConstants.MovementX != 0)
	{
		anim.SetBool(GameConstants.JUMP_ANIMATION1, false);
		anim.SetBool(GameConstants.JUMP_ANIMATION2, false);
		anim.SetBool(GameConstants.WALK_ANIMATION, true);
	}
	else 
	{
		anim.SetBool(GameConstants.JUMP_ANIMATION1, false);
		anim.SetBool(GameConstants.JUMP_ANIMATION2, false);
		anim.SetBool(GameConstants.WALK_ANIMATION, false);
	}
}

protected void RotatePlayer()
{
	switch ( GameManager.instance.IntPlayerIndex){
	case 0:
		if (GameConstants.MovementX > 0)
		{
			player.localScale = new Vector3(0.7f, 0.7f, 1f);
		} 
		else 
		if (GameConstants.MovementX < 0)
		{
			player.localScale = new Vector3(-0.7f, 0.7f, 1f);
		}
	break;
	case 1:
		if (GameConstants.MovementX > 0)
		{
			player.localScale = new Vector3(1.8f, 1.8f, 1f);
		} 
		else 
		if (GameConstants.MovementX < 0)
		{
			player.localScale = new Vector3(-1.8f, 1.8f, 1f);
		}
	break;
	}
}
protected void CoordinatesLimit()
{
    TempPos = transform.position;
    TempPos.x = player.position.x;

    if (TempPos.x < GameConstants.PLAYER_MIN_X)
    TempPos.x = GameConstants.PLAYER_MIN_X;

    if (TempPos.x > GameConstants.PLAYER_MAX_X)
    TempPos.x = GameConstants.PLAYER_MAX_X;

    transform.position = TempPos;
}
}
