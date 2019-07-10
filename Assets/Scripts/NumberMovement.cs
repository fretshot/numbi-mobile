using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMovement : MonoBehaviour{

    private float speed = 4f;

    void Update() {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

}
