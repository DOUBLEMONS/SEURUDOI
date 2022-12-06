using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    public Player_Manager PM;

    void Awake()
    {
        
    }

    void Start()
    {

    }

    private bool IsGround()
    {
        return Physics2D.OverlapCircle(PM.GroundCheck.position, 0.2f, PM.GroundLayer);
    }

    public void OnClick()
    {
        if(PM.JumpCount > 0)
        {
            PM.Rigidbody2D.velocity = new Vector2(PM.Horizontal , PM.JumpPower);
            PM.JumpCount--;
        }
    }

    void Update()
    {
        if (IsGround() && PM.JumpCount == 0)
        {
            PM.JumpCount = 2;
        }
    }

    public void PointerUp()
    {
        PM.Rigidbody2D.velocity = new Vector2(PM.Horizontal , PM.Rigidbody2D.velocity.y * 0.5f);
    }
}
