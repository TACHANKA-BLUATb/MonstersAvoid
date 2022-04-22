using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

[SerializeField]
private GameObject[] characters;
public static GameManager instance;
public string StringPlayerIndex;
private int _intPlayerIndex;
public int IntPlayerIndex
{
	get {return _intPlayerIndex;}
	set {_intPlayerIndex = value;} 
}

private void Awake()
{
	if (instance == null){
		instance = this;
		DontDestroyOnLoad(gameObject);
	}
	else{
		Destroy(gameObject); 
	}
}

private void OnEnable()
{
	SceneManager.sceneLoaded += OnLevelFinishedLoading;
}

private void OnDesable()
{
	SceneManager.sceneLoaded -= OnLevelFinishedLoading;
}

void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
{
	if (scene.name == "Gameplay"){
		Instantiate(characters[IntPlayerIndex]);
	}
}
}
