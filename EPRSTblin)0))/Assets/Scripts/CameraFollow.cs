using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

private Transform player;
private Vector3 TempPos;

void Start () 
{
  player = GameObject.FindWithTag(GameConstants.PLAYER_TAG).transform; 
}

void Update () 
{
  if (!player)
    return;

  TempPos = transform.position;
  TempPos.x = player.position.x;  
  if (TempPos.x < GameConstants.CAM_MIN_X)
    TempPos.x = GameConstants.CAM_MIN_X;

  if (TempPos.x > GameConstants.CAM_MAX_X)
    TempPos.x = GameConstants.CAM_MAX_X; 

  transform.position = TempPos;
}
}

