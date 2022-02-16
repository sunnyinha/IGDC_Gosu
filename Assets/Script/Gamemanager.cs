using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject ghost;
    public GameObject coin;
    public int score;
    public int goal;
    public bool isCheck = false;
    public Transform left_bottom;
    public Transform right_top;

    void Place(GameObject ghost, GameObject coin)
    {
    
        float newX = Random.Range(-10f, 10f), newY = 0, newZ = Random.Range(-10f, 10f);
        float newA = Random.Range(-10f, 10f), newB = 0, newC = Random.Range(-10f, 10f);


        // �ҷ��� ������Ʈ�� �����ϰ� ������ ��ǥ������ ��ġ�� �ű��.
        ghost.transform.position = new Vector3(newX, newY, newZ);
        coin.transform.position = new Vector3(newA, newB, newC);

        //��ó:https://coding-of-today.tistory.com/8
    }
    void CheckClear()
    {
        if (isCheck == true)
        {
            Debug.Log("Clear");
        }
        // ��ó: https://namjuhyung.tistory.com/93
    }
    // Start is called before the first frame update
    void Start()
    {
        Place(ghost, coin);
    }

    // Update is called once per frame
    void Update()
    {
        CheckClear();
    }
};
