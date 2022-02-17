using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; // ���� ������ ���⼭ ����������
   

    void Start()
    {
        speed = 5; // ���� �� �ʱ�ȭ�� ���⼭ �ϰų� inspect â���� �ϱ�!
    }

    void Operationkey(float speed)
    {
        // �¿�
        // ���⼱ �������� ����Ű ������ �ڵ� ���� ����Ƽ edit projet settings���� ��ġ�� �� ����

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate((float)(speed * Time.deltaTime), 0f, 0f); //translate�� position���� ��ġ�� is kinematic ���̵� ����
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
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

    void OnCollisionEnter(Collision collision) //�̰� �浹 �� �ڵ� �۵��̶� update()�� ���� �ʿ� ����!
    // rigidbody �ʿ�! colider �ʿ�! ���� ���� ���ø� ���� Is Kinematic ����...(���ϸ� �� �浹 ������� ȸ������ ������ ����Ű�� ����� �۵� ����..)
    {
        if (collision.gameObject.CompareTag("Collectable")) // �±� �̸����� ������Ʈ ��� ���� ����: https://docs.unity3d.com/kr/2020.3/Manual/Tags.html
        {
            Gamemanager.number++; //�ܺ� static ���� ���� Ŭ���� �̸� ���� ��� �ʿ�  ����:https://8bitscoding.github.io/unity/09/
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Enermy"))
        {
            Debug.Log("Game Over");
            speed = 0;
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        Operationkey(speed);
       

    }
};
