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

    //Main
    [Header("Player_Move")]
    public FixedJoystick FixedJoystick;
    public float speed;
}
