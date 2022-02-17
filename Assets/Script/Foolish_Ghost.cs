using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foolish_Ghost : Ghost //Âü°í: https://ansohxxn.github.io/unity%20lesson%201/chapter7-2/
{
    public Transform left_bottom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Random.Range(-10f, 10f), newY = 0, newZ = Random.Range(-10f, 10f);
        left_bottom.position = new Vector3(newX, newY, newZ);
        ChaseTarget(left_bottom);
    }
} 
