using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Sin_Move : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float ShakeSpeed;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float ShakeRange;

    Vector3 InitPos;

    private void Awake()
    {
        InitPos = transform.position;
    }

    private void Update()
    {
        transform.position = new Vector3(InitPos.x, Mathf.Sin(Time.time * ShakeSpeed) * ShakeRange + InitPos.y, 0);
    }
}
