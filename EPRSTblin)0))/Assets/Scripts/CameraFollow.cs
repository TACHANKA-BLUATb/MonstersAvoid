using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
private Transform player;
private Vector3 TempPos;
[SerializeField]
private float minX, maxX;
private string PlayerTag = "Player 1"; //заменить нахуй
 void Start () {
 		player = GameObject.FindWithTag(PlayerTag).transform; //заменить нахуй
 }
 void Update () {
    TempPos = transform.position;
    TempPos.x = player.position.x;
    transform.position = TempPos;
 }
}
