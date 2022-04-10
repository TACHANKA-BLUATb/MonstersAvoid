using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {
private Transform player;
private Vector3 TempPos;
[SerializeField]
private float minX, maxX;
private string PLAYER_TAG;// заменить нахуй

public string ButtonName;
 public CameraFollow(string buttonName){
   ButtonName = buttonName;
   Debug.Log(ButtonName);
     switch (ButtonName){
        case "0":
        PLAYER_TAG = "Player1";
        break;

        case "1":
        PLAYER_TAG = "Player2";
        break;
    }
    Debug.Log(PLAYER_TAG);
 }

 void Start () {
 		player = GameObject.FindWithTag(PLAYER_TAG).transform; //заменить нахуй
    
 }

 void Update () {
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

