using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    public static Player_Manager Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    //Main
    [Header("Player_Main")]
    public Rigidbody2D Rigidbody2D;

    //Move
    [Header("Player_Movement")]
    public float MoveSpeed;
    public float Horizontal;
    public bool IsFacingRight = true;
    public bool CanMove;
    public Transform Player;

    //Jump
    [Header("Player_Jump")]
    public float JumpPower;
    public Transform GroundCheck;
    public LayerMask GroundLayer;
    public int JumpCount;
}
