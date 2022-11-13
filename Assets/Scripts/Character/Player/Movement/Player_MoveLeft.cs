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
        PM.Horizontal -= 1;
    }

    public void PointerUp()
    {
        PM.Horizontal = 0;
    }

    void Update()
    {
        PM.Rigidbody2D.velocity = new Vector2(PM.Horizontal * PM.MoveSpeed, PM.Rigidbody2D.velocity.y);
    }
}
