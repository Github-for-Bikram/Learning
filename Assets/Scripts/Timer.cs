using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [Header("Variables")]
    public float speed = 0f;
    public float ScaleA;
    public float ScaleB;

    private float t = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        t = (Mathf.Sin(Time.time * speed) + 1f) / 2;



        transform.localScale = new Vector2(transform.localScale.x,Mathf.Lerp(ScaleA,ScaleB,t));


    }
}
