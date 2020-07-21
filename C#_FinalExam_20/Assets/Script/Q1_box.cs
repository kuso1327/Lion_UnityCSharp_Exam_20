using UnityEngine;

public class Q1_box : MonoBehaviour
{    
    [Header("移動速度"),Range(0,100)]
    public float speed;    
    [Header("目標位置")]
    public Transform originPos;      

    private void Update()
    {
        Move();
    }
    public void Move()
    {
        transform.Translate(Time.deltaTime * speed, 0, 0);
        float dis =Vector3.Distance(originPos.position, transform.position);
        if (dis>=10)
        {
            speed = 0;
        }
    }

    

}
