using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Screen_Lerp_Move : MonoBehaviour
{
    public Transform StartPostion;
    private Vector3 StartPoint;
    public Transform EndPostion;
    private Vector3 EndPoint;
    public float DesiredDuration = 3f;
    private float ElapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        StartPoint = new Vector3(StartPostion.position.x, StartPostion.position.y, 0);
        EndPoint = new Vector3(EndPostion.position.x, EndPostion.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;
        float percentageComplete = ElapsedTime / DesiredDuration;

        transform.position = Vector3.Lerp(StartPoint, EndPoint, Mathf.SmoothStep(0, 1, percentageComplete));
    }
}
