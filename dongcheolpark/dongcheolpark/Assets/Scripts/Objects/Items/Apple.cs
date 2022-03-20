using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    void Awake() {
        GameData.getInstance().StageAppleCount++;
    }
    void OnTriggerEnter2D(Collider2D coll) {
        if(GameData.getInstance().StageAppleCount == 1) {
            GameData.getInstance().StageAppleCount = 0;
            GameManager.GetInstance().status = GameManager.gameStatus.Clear;
        }
        else {
            Debug.Log("a");
            GameData.getInstance().StageAppleCount--;
            Destroy(this.gameObject);
        }
    }
}
