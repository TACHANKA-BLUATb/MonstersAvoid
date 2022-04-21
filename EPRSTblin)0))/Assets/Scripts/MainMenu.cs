using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public interface PlayersTag{

}

public class MainMenu : CameraFollow {
   public override void startGame(){
      string _buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
      SceneManager.LoadScene("Gameplay");
   }
}
// private Transform player;
// private Vector3 TempPos;
// [SerializeField]
// private float minX, maxX;
// public string PLAYER_TAG;
// // protected string ButtonName;
// public void StartGame(){
//     string _buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
//      switch (_buttonName){
//         case "0":
//         PLAYER_TAG = "Player1";
//         break;
//         case "1":
//         PLAYER_TAG = "Player2";
//         break;
//     }
// 	SceneManager.LoadScene("Gameplay");
// }
//  void Start () {
//  		// StartCoroutine(LateStart());
//  }
// //  IEnumerator LateStart(){
// //     yield return new WaitForSeconds(10);
// //     player = GameObject.FindWithTag(PLAYER_TAG).transform; 
// //  }

// //  void Update () {
// //     if (!player)
// //       return;
      
// //     TempPos = transform.position;
// //     TempPos.x = player.position.x;

// //     if (TempPos.x < minX)
// //     TempPos.x = minX;

// //     if (TempPos.x > maxX)
// //     TempPos.x = maxX;

// //     transform.position = TempPos;
// //  }
// }
