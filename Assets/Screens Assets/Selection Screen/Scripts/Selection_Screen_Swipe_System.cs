//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Selection_Screen_Swipe_System : MonoBehaviour
//{
//    [SerializeField]
//    private Scrollbar Scrollbar; // Scrollbar의 위치를 바탕으로 전체 페이지 검사
//    [SerializeField]
//    private float SwipeTime = 0.2f; // 페이지가 Swipe 되는 시간
//    [SerializeField]
//    private float SwipeDistance = 50.0f; // 페이지가 Swipe되기 위해 움직여야 하는 최소 거리

//    private float[] ScrollPageValues; // 각 페이지의 위치 값 [0.0 ~ 1.0]
//    private float ValueDistance = 0; // 각 페이지 사이의 거리
//    private int CurrentPage = 0; // 현재 페이지
//    private int MaxPage = 0; // 최대 페이지
//    private float StartTouchX; // 터치 시작 위치
//    private float EndTouchY; // 터치 종료 위치
//    private bool IsSwipeMode = false; // 현재 Swipe가 되고 있는지 체크 

//    void Awake()
//    {
//        // 스크롤 되는 페이지의 각 value 값을 지정하는 배열 메모리 할당
//        ScrollPageValues = new float[transform.childCount];

//        // 스크롤 되는 페이지 사이의 거리 
//        ValueDistance = 1f / (ScrollPageValues.Length - 1f);

//        // 스크롤 되는 페이지의 각 value 위치 설정 [0 <= value <= 1]
//        for (int i = 0; i < ScrollPageValues.Length; ++i)
//        {
//            ScrollPageValues[i] = ValueDistance * i;
//        }

//        // 최대 페이지의 수
//        MaxPage = transform.childCount;
//    }

//    void Start()
//    {
//        // 최초 시작할 때 0번 페이지를 볼 수 있도록 설정
//        SetScrollBarValue(0);
//    }

//    public void SetScrollBarValue(int index)
//    {
//        CurrentPage = index;
//        Scrollbar.value = ScrollPageValues[index];
//    }

//    void Update()
//    {
//        UpdateInput();
//    }

//    private void UpdateInput()
//    {
//        // 현재 Swipe를 진행중이면 터치 불가 
//        if (IsSwipeMode == true) return;

//#if UNITY_EDITOR
//        // 마우스 왼쪽 버튼을 눌렀을 때 1회
//        if (Input.GetMouseButtonDown(0))
//        {
//            // 터치 시작 지점 (Swipe 방향 구분)
//            StartTouchX = Input.mousePosition.x;
//        }
//        else if (Input.GetButtonUp(0))
//        {
//            // 터치 종료 시점 (Swipe 방향 구분)
//            EndTouchY = Input.mousePosition.x;

//            UpdateInput();
//        }
//    }
//}