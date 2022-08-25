using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [Header("Variables")]
    public float speed = 0f;
    public float ScaleA;
    public float ScaleB;
    public Color color1;
    public Color color2;


    private float t = 0f;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }


    // Update is called once per frame
    void Update()
    {
        t = (Mathf.Sin(Time.time * speed) + 1f) / 2;
        
        spriteRenderer.color = Color.Lerp(color1,color2,t);
        transform.localScale = new Vector2(transform.localScale.x,Mathf.Lerp(ScaleA,ScaleB,t));


    }


}
