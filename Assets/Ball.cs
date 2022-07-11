using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float currentSpeed;
    public float speed = 5.25f;
    public Rigidbody2D rb;
    public TrailRenderer tr;

    void Start()
    {
        currentSpeed = speed;
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<TrailRenderer>();
        rb.velocity = Vector2.left * currentSpeed;
    }

    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "PlayerOne")
        {
            float y = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            rb.velocity = dir * currentSpeed;
            currentSpeed = currentSpeed + 1;
        }

        if (col.gameObject.name == "PlayerTwo")
        {
            float y = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            rb.velocity = dir * currentSpeed;
            currentSpeed = currentSpeed + 1;
        }

        if(col.gameObject.name == "GoalLeft")
        {
            transform.position = Vector2.zero;
            GameManager.score02 += 1;
            rb.velocity = Vector2.right * speed;
            tr.Clear();
        }

        if(col.gameObject.name == "GoalRight")
        {
            transform.position = Vector2.zero;
            GameManager.score01 += 1;
            rb.velocity = Vector2.left * speed;
            tr.Clear();
        }
    }
}

