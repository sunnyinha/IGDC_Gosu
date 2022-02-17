using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform player;
    public float speed;
    
    protected void ChaseTarget(Transform player)
    {
        this.transform.LookAt(player);
        this.transform.position = Vector3.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
