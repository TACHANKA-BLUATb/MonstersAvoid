using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectorScript : MonoBehaviour {
public Text Coins;
private int score;
private void Update(){
	Coins.text = score.ToString();
}
public void Jumped(){
	score++;
}
}
