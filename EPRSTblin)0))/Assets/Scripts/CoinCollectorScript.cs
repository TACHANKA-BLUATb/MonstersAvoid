using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectorScript : MonoBehaviour {

public Text Coins;
public Text Level;
private int score;
private bool LevelChek = false;

private void Update()
{
	LevelCoinCollector();
	InfiniteCoinCollector();
}

public void Jumped()
{
	score++;
}

public void LevelCoinChek()
{
	LevelChek = true;
}

private void LevelCoinCollector()
{
	if (LevelChek == true)
	{
		if (score < 10)
		{
			Coins.text = score.ToString() + "/10";
			Level.text = "Level 1";
		}
		else
		if (score < 30)
		{
			Coins.text = score.ToString() + "/30";
			Level.text = "Level 2";
		}
		else
		if (score < 50)
		{
			Coins.text = score.ToString() + "/50";
			Level.text = "Level 3";
		}
		else
		{
			Level.text = "You Won!";
		}
	}
}

private void InfiniteCoinCollector()
{
	if (LevelChek == false)
		Coins.text = score.ToString();
}

}

