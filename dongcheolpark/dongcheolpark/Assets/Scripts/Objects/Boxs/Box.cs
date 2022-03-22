using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : BounceGameObj
{
    void OnCollisionEnter2D(Collision2D coll) {
        coll.gameObject.GetComponent<Player>().Jump();
    }
}