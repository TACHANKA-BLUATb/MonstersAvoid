using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {
[SerializeField]
private GameObject[] monsterReference;
private GameObject spawnedMonster;

[SerializeField]
private Transform leftPos, rightPos;
private int randomIndex;
private int ramdomSite;	
	void Start () {
		StartCoroutine(SpawnMomsters());
	}
	IEnumerator SpawnMomsters(){
		yield return new WaitForSeconds(Random.Range(1,5));
		randomIndex = Random.Range(0, monsterReference.Length);
	}
	
	void Update () {
		
	}
}
