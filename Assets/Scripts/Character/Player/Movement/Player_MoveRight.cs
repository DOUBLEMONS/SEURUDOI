using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_MoveRight : MonoBehaviour
{
    public Player_Manager PM;

    void Start()
    {

    }

    public void PointerDown()
    {
        PM.Horizontal = 1;
        PM.Player.transform.rotation = Quaternion.Euler(0, 0, 0);
        PM.IsFacingRight = true;
    }

    public void PointerUp()
    {
        PM.Horizontal = 0;
    }

    void LateUpdate()
    {
        PM.Rigidbody2D.velocity = new Vector2(PM.Horizontal * PM.MoveSpeed, PM.Rigidbody2D.velocity.y);
    }
}
