using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update() {
        if(Input.GetAxis("Horizontal") != 0) {
            GameManager.GetInstance().sceneManager.player.move(new Vector2(Input.GetAxis("Horizontal"),0));
        }
        else {
            GameManager.GetInstance().sceneManager.player.move(new Vector2(0,0));
        }
    }
}