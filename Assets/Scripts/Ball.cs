using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    public Transform spawnpoint;

    public GameObject hitSound;
    public GameObject failSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameManager.lives = 3;
    }

    private void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var brick = collision.gameObject.GetComponent<Brick>();
        if (brick != null)
        {
            brick.Damage();
            Instantiate(hitSound);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("DeathZone"))
        {
            Instantiate(failSound);
            GameManager.lives--;
            transform.position = spawnpoint.position;
        }
    }
}
