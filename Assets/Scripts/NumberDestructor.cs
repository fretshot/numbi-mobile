using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberDestructor : MonoBehaviour{

    public Gameplay gameplay;

    void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
        gameplay.playerLost();
    }
}
