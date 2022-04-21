using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {
private Transform player;
private Vector3 TempPos;
[SerializeField]
private float minX, maxX;
void Start () 
{
  player = GameObject.FindWithTag(GameManager.instance.StringPlayerIndex).transform; 
}

void Update () 
{
  if (!player)
    return;

  TempPos = transform.position;
  TempPos.x = player.position.x;  
  if (TempPos.x < minX)
    TempPos.x = minX;

  if (TempPos.x > maxX)
    TempPos.x = maxX; 

  transform.position = TempPos;
}
}

