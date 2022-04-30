using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {

[SerializeField]
private GameObject[] monsterReference;
private GameObject spawnedMonster;
private Transform leftPos, rightPos;
private int randomIndex;
private int randomSide;	
private int minSpeed = 4;
private int maxSpawnTime = 5;

void Start ()
{
	StartCoroutine(SpawnMonsters());
}

public void LevelTwo()
{
	minSpeed = 6;
	maxSpawnTime = 4;
}

public void LevelThree()
{
	minSpeed = 8;
	maxSpawnTime = 3;
}


IEnumerator SpawnMonsters()
{
	while (true)
	{
		yield return new WaitForSeconds(Random.Range(1,5));
		randomIndex = Random.Range(0, monsterReference.Length);
		randomSide = Random.Range(0, 2);
		spawnedMonster = Instantiate(monsterReference[randomIndex]);
		if (randomSide == 0)
		{
			spawnedMonster.transform.position = leftPos.position;
			spawnedMonster.GetComponent<MonsterMovement>().speed = Random.Range(minSpeed, 10);
		}
		else 
		{
			spawnedMonster.transform.position = rightPos.position;
			spawnedMonster.GetComponent<MonsterMovement>().speed = -Random.Range(minSpeed, 10);
			spawnedMonster.transform.localScale = new Vector3(-0.7f, 0.7f, 1f);
		}
	}
}
}
