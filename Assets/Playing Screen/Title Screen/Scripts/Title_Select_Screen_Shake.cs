using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Select_Screen_Shake : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float ShakeSpeed;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float ShakeRange;

    //[SerializeField]
    //private AnimationCurve AnimationCurve;

    private void Awake()
    {

    }

    private void Update()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time * ShakeSpeed) * ShakeRange, 0);
    }
}
