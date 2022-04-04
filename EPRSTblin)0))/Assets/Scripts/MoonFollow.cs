using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonFollow : MonoBehaviour {
private Transform Camera;
private Vector3 TempPos;
// Use this for initialization
void Start () {
	Camera = GameObject.FindWithTag("MainCamera").transform;
}// Update is called once per frame
void Update () {
	TempPos = transform.position;
	TempPos.x = Camera.position.x * 10 / 11;
	transform.position = TempPos;
}
}
