using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float bouncespeed,speed;
    private Rigidbody2D rb2D;
    void Awake() {
        bouncespeed = 3300;
        speed = 5;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(Input.GetAxis("Horizontal") != 0) {
            move(new Vector2(Input.GetAxis("Horizontal"),0));
        }
        else{
            move(new Vector2(0,0));
        }
    }

    public void Jump() {
        GameManager.GetInstance().soundManager.BounceSound();
        rb2D.AddForce(Vector2.up*bouncespeed);
    }
    
    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.GetComponent<Spike>() != null) {
            GameData.getInstance().StageAppleCount = 0;
            GameManager.GetInstance().status = GameManager.gameStatus.Death;
            Debug.Log("죽었습니다.");
            Destroy(this);
        }
    }
    public void move(Vector2 dir) {
        rb2D.velocity = new Vector2(dir.x*speed,rb2D.velocity.y);
    }
}
