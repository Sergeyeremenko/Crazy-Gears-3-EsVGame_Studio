using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform platforms;
    public float speed;
    public Transform explosion;
    public Transform powerup;
    AudioSource audio;
    public GameManager gm;
    [SerializeField]
    public GameObject StGa;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    bool isPlay = false;
    public void StGaaaa()
    {
        if (isPlay)
        {
            inPlay = false;
            Debug.Log("no");
        }
        else
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
            Debug.Log("Forsage");
        }
    }
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        if (!inPlay)
        {
            transform.position = platforms.position;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Button"))
        {
            rb.velocity = Vector2.zero;
            inPlay = false;
            gm.UpdateLives(-1);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Brick"))
        {
            BrickScript brickScript = other.gameObject.GetComponent<BrickScript>();
            if (brickScript.hitsToBreak > 1)
            { brickScript.BreakBrick(); }
            else
            {
                int randChance = Random.Range(1, 101);
                if (randChance < 50)
                {
                    Instantiate(powerup, other.transform.position, other.transform.rotation);
                }
                Transform newExplosion = Instantiate(explosion, other.transform.position, other.transform.rotation);
                Destroy(newExplosion.gameObject, 2.5f);
                gm.UpdateScore(brickScript.points);
                gm.UpdateNumberOfBricks();
                Destroy(other.gameObject);
            }
            audio.Play();
        }
    }
}
