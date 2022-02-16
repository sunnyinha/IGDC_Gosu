using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; //������ ���⼭ ����������

    void Start()
    {
        speed = 5; // �� �ʱ�ȭ�� ���⼭ �ؾ���
    }
    void Update()
    {
        // �¿�
        // ���⼱ �������� ����Ű ������ �ڵ� ���� ����Ƽ edit projet settings���� ��ġ�� �� ����

        if(Input.GetAxisRaw("Horizontal")>0 )
        {
            transform.Translate((float)(speed * Time.deltaTime), 0f, 0f);
        }
        if ( Input.GetAxisRaw("Horizontal") < 0) 
        {
            transform.Translate(-(float)(speed * Time.deltaTime), 0f, 0f);
        }
        // ����
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(0f, 0f, (float)(speed * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(0f, 0f, -(float)(speed * Time.deltaTime));
        }
        //���� : https://polygonstudio.tistory.com/213
    }
};
