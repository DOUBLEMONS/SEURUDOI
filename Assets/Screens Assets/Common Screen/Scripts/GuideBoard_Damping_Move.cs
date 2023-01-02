using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideBoard_Damping_Move : MonoBehaviour
{
    public Transform StartPosition;
    private Vector3 StartPoint;
    public Transform EndPosition;
    private Vector3 EndPoint;
    public float DesiredDuration = 3f;
    public float ElapsedTime = 0;

    [SerializeField]
    private AnimationCurve AnimationCurve;

    void Awake()
    {
        
    }

    void Start()
    {
        StartPoint = new Vector3(StartPosition.position.x, StartPosition.position.y, 0);
        EndPoint = new Vector3(EndPosition.position.x, EndPosition.position.y, 0);
    }

    void Update()
    {
        ElapsedTime += Time.deltaTime;
        float percentageComplete = ElapsedTime / DesiredDuration;

        transform.position = Vector3.Lerp(StartPoint, EndPoint, AnimationCurve.Evaluate(percentageComplete));
    }

    public void Return()
    {
        ElapsedTime = 0;
        gameObject.GetComponent<GuideBoard_Return>().enabled = true;
        gameObject.GetComponent<GuideBoard_Damping_Move>().enabled = false;
    }
}

