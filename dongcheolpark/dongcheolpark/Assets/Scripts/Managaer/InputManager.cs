using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    SceneManager sceneManager;
    void start() {
        sceneManager = GameManager.GetInstance().sceneManager;
    }
    void Update() {
        if(Input.GetAxis("Horizontal") != 0) {
            sceneManager.move(new Vector2(Input.GetAxis("Horizontal"),0));
        }
    }
}