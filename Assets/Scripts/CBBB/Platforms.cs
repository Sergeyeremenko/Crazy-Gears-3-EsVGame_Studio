using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public float speed;
    public float rightScreenEdge;
    public float LeftScreenEdge;
    public GameManager gm;

    void Start()
    {
        
    }
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate (Vector2.right * horizontal * Time.deltaTime * speed); 
        if (transform.position.x < LeftScreenEdge)
        {
            transform.position = new Vector2(LeftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }
    }
    /// <summary>
    /// Добавляем жизнь после прохождения через платформу:
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("extraLife"))
        {
            gm.UpdateLives(1);
            Destroy(other.gameObject);
        }
        //Debug.Log ("hit" + other.name);
    }
}
