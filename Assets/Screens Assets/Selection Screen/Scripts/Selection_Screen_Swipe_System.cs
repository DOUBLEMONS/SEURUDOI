//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Selection_Screen_Swipe_System : MonoBehaviour
//{
//    [SerializeField]
//    private Scrollbar Scrollbar; // Scrollbar�� ��ġ�� �������� ��ü ������ �˻�
//    [SerializeField]
//    private float SwipeTime = 0.2f; // �������� Swipe �Ǵ� �ð�
//    [SerializeField]
//    private float SwipeDistance = 50.0f; // �������� Swipe�Ǳ� ���� �������� �ϴ� �ּ� �Ÿ�

//    private float[] ScrollPageValues; // �� �������� ��ġ �� [0.0 ~ 1.0]
//    private float ValueDistance = 0; // �� ������ ������ �Ÿ�
//    private int CurrentPage = 0; // ���� ������
//    private int MaxPage = 0; // �ִ� ������
//    private float StartTouchX; // ��ġ ���� ��ġ
//    private float EndTouchY; // ��ġ ���� ��ġ
//    private bool IsSwipeMode = false; // ���� Swipe�� �ǰ� �ִ��� üũ 

//    void Awake()
//    {
//        // ��ũ�� �Ǵ� �������� �� value ���� �����ϴ� �迭 �޸� �Ҵ�
//        ScrollPageValues = new float[transform.childCount];

//        // ��ũ�� �Ǵ� ������ ������ �Ÿ� 
//        ValueDistance = 1f / (ScrollPageValues.Length - 1f);

//        // ��ũ�� �Ǵ� �������� �� value ��ġ ���� [0 <= value <= 1]
//        for (int i = 0; i < ScrollPageValues.Length; ++i)
//        {
//            ScrollPageValues[i] = ValueDistance * i;
//        }

//        // �ִ� �������� ��
//        MaxPage = transform.childCount;
//    }

//    void Start()
//    {
//        // ���� ������ �� 0�� �������� �� �� �ֵ��� ����
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
//        // ���� Swipe�� �������̸� ��ġ �Ұ� 
//        if (IsSwipeMode == true) return;

//#if UNITY_EDITOR
//        // ���콺 ���� ��ư�� ������ �� 1ȸ
//        if (Input.GetMouseButtonDown(0))
//        {
//            // ��ġ ���� ���� (Swipe ���� ����)
//            StartTouchX = Input.mousePosition.x;
//        }
//        else if (Input.GetButtonUp(0))
//        {
//            // ��ġ ���� ���� (Swipe ���� ����)
//            EndTouchY = Input.mousePosition.x;

//            UpdateInput();
//        }
//    }
//}