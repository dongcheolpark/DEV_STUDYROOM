using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2D;
    void Awake() {
        speed = 5;
        rb2D = GetComponent<Rigidbody2D>();
    }
    public void move(Vector2 dir) {
        rb2D.velocity = dir * speed;
    }
}
