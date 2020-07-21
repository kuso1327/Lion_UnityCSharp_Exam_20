using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public delegate void RunnerDel();

    public event RunnerDel Goal;

    [Header("移動速度"), Range(0, 100)]
    public float speed;
    [Header("目標位置")]
    public Transform originPos;
    public Animator ani;


    private void Update()
    {
        Move();
    }

    public void Move()
    {
        
        transform.Translate(0, 0, Time.deltaTime * speed);
        float dis = Vector3.Distance(originPos.position, transform.position);
        if (dis >= 10)
        {
            speed = 0;            
            //Goal();
        }
    }
}
