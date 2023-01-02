using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideBoard_Return : MonoBehaviour
{
    public Transform StartPostion;
    private Vector3 StartPoint;
    public Transform EndPostion;
    private Vector3 EndPoint;
    public float DesiredDuration = 3f;
    public float ElapsedTime = 0;

    void Start()
    {
        StartPoint = new Vector3(StartPostion.position.x, StartPostion.position.y, 0);
        EndPoint = new Vector3(EndPostion.position.x, EndPostion.position.y, 0);
    }

    void Update()
    {
        ElapsedTime += Time.deltaTime;
        float percentageComplete = ElapsedTime / DesiredDuration;

        transform.position = Vector3.Lerp(StartPoint, EndPoint, Mathf.SmoothStep(0, 1, percentageComplete));
    }

    public void Damping_Move()
    {
        ElapsedTime = 0;
        gameObject.GetComponent<GuideBoard_Damping_Move>().enabled = true;
        gameObject.GetComponent<GuideBoard_Return>().enabled = false;
    }
}
