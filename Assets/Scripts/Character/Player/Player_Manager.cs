using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    public static Player_Manager Instance;

    void Awake()
    {
        Instance = this;
        Application.targetFrameRate = 60;
    }

    //Main
    [Header("Player_Main")]
    public Rigidbody2D Rigidbody2D;

    //Move
    [Header("Player_Movement")]
    public float MoveSpeed;
    public float Horizontal;
    public bool IsFacingRight = true;

    //Jump
    [Header("Player_Jump")]
    public float JumpPower;
}
