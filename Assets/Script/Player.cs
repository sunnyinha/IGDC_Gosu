using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; //선언은 여기서 가능하지만

    void Start()
    {
        speed = 5; // 값 초기화는 여기서 해야함
    }
    void Update()
    {
        // 좌우
        // 여기선 안했지만 조작키 변경은 코드 말고 유니티 edit projet settings에서 고치는 게 빠름

        if(Input.GetAxisRaw("Horizontal")>0 )
        {
            transform.Translate((float)(speed * Time.deltaTime), 0f, 0f);
        }
        if ( Input.GetAxisRaw("Horizontal") < 0) 
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
};
