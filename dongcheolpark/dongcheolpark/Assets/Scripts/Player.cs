using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float bouncespeed,speed;
    private Rigidbody2D rb2D;
    void Awake() {
        bouncespeed = 2500;
        speed = 5;
        rb2D = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag.Equals("Block"))
        {
            GameObject colBlock = coll.gameObject;
        }
        rb2D.AddForce(Vector2.up*bouncespeed);
    }
    public void move(Vector2 dir) {
        Debug.Log(dir);
        rb2D.velocity = new Vector2(dir.x*speed,rb2D.velocity.y);
    }
}
