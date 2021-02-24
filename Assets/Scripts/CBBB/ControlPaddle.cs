using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPaddle : MonoBehaviour
{
    public float horizontalSpeed;
    float speedX;
    public float verticalImpulse;
    Rigidbody2D rb;
    public GameManager gm;
    public Transform platforms;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void LeftButtonDown()
    {
        speedX = -horizontalSpeed;
        Debug.Log("лево");
    }
    public void RightButtonDown()
    {
        speedX = horizontalSpeed;
        Debug.Log("вправо");
    }
    public void Stop()
    {
        speedX = 0;
    }
    void FixedUpdate()
    {
        transform.Translate(speedX, 0, 0);
    }
}
