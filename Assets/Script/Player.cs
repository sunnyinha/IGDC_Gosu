using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; // 변수 선언은 여기서 가능하지만
   

    void Start()
    {
        speed = 5; // 변수 값 초기화는 여기서 하거나 inspect 창에서 하기!
    }

    void Operationkey(float speed)
    {
        // 좌우
        // 여기선 안했지만 조작키 변경은 코드 말고 유니티 edit projet settings에서 고치는 게 빠름

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate((float)(speed * Time.deltaTime), 0f, 0f); //translate를 position으로 고치면 is kinematic 없이도 가능
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(-(float)(speed * Time.deltaTime), 0f, 0f);
        }
        // 상하
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(0f, 0f, (float)(speed * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(0f, 0f, -(float)(speed * Time.deltaTime));
        }
        //참고 : https://polygonstudio.tistory.com/213
    }

    void OnCollisionEnter(Collision collision) //이건 충돌 시 자동 작동이라 update()에 넣을 필요 없음!
    // rigidbody 필요! colider 필요! 물리 엔진 무시를 위해 Is Kinematic 설정...(안하면 공 충돌 충격으로 회전축이 움직여 조작키가 제대로 작동 못해..)
    {
        if (collision.gameObject.CompareTag("Collectable")) // 태그 이름으로 오브젝트 언급 가능 참고: https://docs.unity3d.com/kr/2020.3/Manual/Tags.html
        {
            Gamemanager.number++; //외부 static 변수 사용시 클래스 이름 같이 언급 필요  참고:https://8bitscoding.github.io/unity/09/
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
