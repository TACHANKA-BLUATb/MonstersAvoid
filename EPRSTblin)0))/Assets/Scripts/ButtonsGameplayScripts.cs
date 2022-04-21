using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGameplayScripts : MonoBehaviour {

public void RestartGame(){
	SceneManager.LoadScene("Gameplay");
}

public void Home(){
	SceneManager.LoadScene("MainMenu");
}
}
