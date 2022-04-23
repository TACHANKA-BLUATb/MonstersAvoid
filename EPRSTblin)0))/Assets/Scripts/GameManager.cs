using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

public static GameManager instance;
[SerializeField]
private GameObject[] characters;
private CoinCollectorScript Coins;
private MonsterSpawner Level;
private CoinCollectorScript CoinCheker;
private bool LevelModeChek = false;
public int CoinCollector;
private int CoinCollectorController;
public string StringPlayerIndex;
private int _intPlayerIndex;
public int IntPlayerIndex
{
	get {return _intPlayerIndex;}
	set {_intPlayerIndex = value;} 
}

private void Awake()
{
	if (instance == null)
	{
		instance = this;
		DontDestroyOnLoad(gameObject);
	}
	else
	{
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
	if (scene.name == "Gameplay")
	{
		Instantiate(characters[IntPlayerIndex]);
		Coins = FindObjectOfType<CoinCollectorScript>();
		Level = FindObjectOfType<MonsterSpawner>();
	}
	if (LevelModeChek == true)
	{
	CoinCheker = FindObjectOfType<CoinCollectorScript>();
	CoinCheker.LevelCoinChek();
	}
}

private void Update()
{
	CoinsControl();
	LevelModeActive();
}

void CoinsControl()
{
	if (CoinCollectorController != CoinCollector)
	{
		Coins.Jumped();
		CoinCollectorController = CoinCollector;
	}
}

public void LevelModeCheker()
{
	LevelModeChek = true;
}

void LevelModeActive()
{
	if (LevelModeChek == true)
	{
		switch (CoinCollector){
			case 10:
				Level.LevelTwo();
			break;
			case 30:
				Level.LevelThree();
			break;
			case 50:
			LevelModeChek = false;
			Invoke("sceneLoad", 5);
			break;
		}
	}
}

void sceneLoad()
{
	SceneManager.LoadScene("MainMenu");
}
}
