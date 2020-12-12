using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool isRotatingL = false;
    private int rotateDir;
    public static float rotationSpeed = 20f;
    private int rotateTime;
    // Start is called before the first frame update
    void Start()
    {
        rotateDir = Random.Range(1, 10);
        rotateTime = Random.Range(4, 8);
    }

    // Update is called once per frame
    void Update()
    {    
        if(rotateDir % 2 == 0)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
            if (isRotatingL == false)
            {
                isRotatingL = true;
                StartCoroutine(NextRotation());
            }
        }
        else
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * -rotationSpeed);
             if(isRotatingL == false)
             {
                isRotatingL = true;
                StartCoroutine(NextRotation());
             }
        } 
    }

    IEnumerator NextRotation()
    {
        rotateDir = Random.Range(1, 10);
        yield return new WaitForSeconds(rotateTime);
        isRotatingL = false;
    }
}
