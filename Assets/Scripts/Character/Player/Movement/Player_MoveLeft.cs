using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_MoveLeft : MonoBehaviour
{
    public Player_Manager PM;

    void Start()
    {

    }

    public void PointerDown()
    {
        PM.Horizontal = -PM.MoveSpeed * PM.MoveSpeed;
    }

    public void PointerUp()
    {
        PM.Horizontal = 0;
    }

    void FixedUpdate()
    {
        PM.Rigidbody2D.velocity = new Vector2(PM.Horizontal, PM.Rigidbody2D.velocity.y);
    }
}
