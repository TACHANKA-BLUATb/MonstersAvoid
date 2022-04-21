using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
   public void startGame(){
      string stringButtonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
      int intButtonName = 
         int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
      
      GameManager.instance.StringPlayerIndex = stringButtonName;
      GameManager.instance.IntPlayerIndex = intButtonName;
      SceneManager.LoadScene("Gameplay");
   }
}

