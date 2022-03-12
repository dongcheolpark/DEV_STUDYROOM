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
        Debug.Log(dir);
        rb2D.velocity = new Vector2(dir.x*speed,rb2D.velocity.y);
    }
}
