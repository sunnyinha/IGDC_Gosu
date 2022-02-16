using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject ghost;
    public GameObject coin;
    public int score;
    public int goal;
    public static int number;  //����: https://dlemrcnd.tistory.com/8
    public bool onetime = false; 
    public bool isCheck = false;
    public Transform left_bottom;
    public Transform right_top;

    void Place(GameObject ghost, GameObject coin)
    {
        // ������ ��ǥ �� ����
        float newX = Random.Range(-10f, 10f), newY = 0, newZ = Random.Range(-10f, 10f);
        float newA = Random.Range(-10f, 10f), newB = 0, newC = Random.Range(-10f, 10f);


        // �ҷ��� ������Ʈ�� �����ϰ� ������ ��ǥ������ ��ġ�� �ű��.
        ghost.transform.position = new Vector3(newX, newY, newZ);
        coin.transform.position = new Vector3(newA, newB, newC);

        //��ó:https://coding-of-today.tistory.com/8
    }
    void CheckClear()
    {
        if (score >= goal)
        {
            isCheck = true;
        }
        if (isCheck == true)
        {
            if(onetime == false)
            {
                Debug.Log("Clear");
            }
            onetime = true;

        }

        // ���� : https://namjuhyung.tistory.com/93
    }
    void RaiseScore(int number)
    {
        score = number;

    }

    void Start()
    {
        Place(ghost, coin);
    }


    void Update()
    {
        CheckClear();
        RaiseScore(number);
    }
};
