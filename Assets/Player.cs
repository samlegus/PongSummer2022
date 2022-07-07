using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public float speed = 2.5f;

    void FixedUpdate()
    {
        if(Input.GetKey(upKey))
        {
            transform.Translate(Vector2.up * speed);
        }

        if(Input.GetKey(downKey))
        {
            transform.Translate(Vector2.down * speed);
        }
    }
}
