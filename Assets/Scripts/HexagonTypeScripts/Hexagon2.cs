using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon2 : MonoBehaviour
{
    public Rigidbody2D rb;

    public static float shrinkSpeed = 2f;
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if(transform.localScale.x <= 0.2f) 
        {
            Destroy(gameObject);
        }
    }
}
