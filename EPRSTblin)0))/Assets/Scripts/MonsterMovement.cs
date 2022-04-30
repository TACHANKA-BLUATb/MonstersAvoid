using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour {

[SerializeField]
public float speed;
public Transform Player;
private Rigidbody2D myBody;
private bool CoinControl = true;

void Start()
{
	Player = GameObject.FindWithTag(GameConstants.PLAYER_TAG).transform;
}

void Awake ()
{
	myBody = GetComponent<Rigidbody2D>();	
}

void FixedUpdate ()
{
	myBody.velocity = new Vector2(speed, myBody.velocity.y);
}

void Update()
{
	if (CoinControl == true & Player)
	{
		if (Player.position.y > 0.9)
		{
			if (Player.position.x - transform.position.x < 0.5 & Player.position.x - transform.position.x > -0.5)
			{
				GameManager.instance.CoinCollector = GameManager.instance.CoinCollector + 1;
				CoinControl = false;
			}
		}
	}
}
}
