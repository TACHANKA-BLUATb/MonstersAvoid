using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
CameraFollow PlayerNumberChoise;
public void StartGame(){
    string _buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

    PlayerNumberChoise = new CameraFollow(_buttonName);
    Debug.Log(PlayerNumberChoise.ButtonName);

	SceneManager.LoadScene("Gameplay");
}
}
