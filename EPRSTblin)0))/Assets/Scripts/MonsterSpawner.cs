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
private int ramdomSide;	
private int minSpeed = 4;
private int maxSpawnTime = 5;

void Start ()
{
	StartCoroutine(SpawnMomsters());
}

public void LevelTwo()
{
	Debug.Log("level 2");
	minSpeed = 6;
	maxSpawnTime = 4;
}

public void LevelThree()
{
	Debug.Log("level 3");
	minSpeed = 8;
	maxSpawnTime = 3;
}


IEnumerator SpawnMomsters()
{
	while (true)
	{
		yield return new WaitForSeconds(Random.Range(1,5));
		randomIndex = Random.Range(0, monsterReference.Length);
		ramdomSide = Random.Range(0, 2);
		spawnedMonster = Instantiate(monsterReference[randomIndex]);
		if (ramdomSide == 0)
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
