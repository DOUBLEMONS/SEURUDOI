using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Player_Manager PM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float H = PM.FixedJoystick.Horizontal;

        PM.Rigidbody2D.velocity = new Vector3(H, 0, 0) * PM.speed;
    }
}
