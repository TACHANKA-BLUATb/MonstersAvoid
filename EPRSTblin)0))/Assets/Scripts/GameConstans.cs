using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameConstants {
public static readonly float MoveForce = 5f;
public static readonly float JumpForce = 11f;
public static float MovementX;
public static readonly int CAM_MIN_X = -30;
public static readonly int CAM_MAX_X = 30;
public static readonly int PLAYER_MAX_X = 39;
public static readonly int PLAYER_MIN_X = -39;
public static readonly string WALK_ANIMATION = "Walk";
public static readonly string GROUND_TAG = "Ground";
public static readonly string PLAYER_TAG = "Player";
public static readonly string ENEMY_TAG = "Enemy"; 
public static readonly string JUMP_ANIMATION1 = "Jump1";
public static readonly string JUMP_ANIMATION2 = "Jump2";
}
