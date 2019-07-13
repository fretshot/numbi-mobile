using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMovement : MonoBehaviour{

    private float speed = Gameplay.initialSpeed;

    void Update() {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }

}
