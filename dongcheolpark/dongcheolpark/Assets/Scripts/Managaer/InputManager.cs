using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update() {
        if(Input.GetAxis("Horizontal") != 0) {
            GameManager.GetInstance().sceneManager.move(new Vector2(Input.GetAxis("Horizontal"),0));
        }
    }
}