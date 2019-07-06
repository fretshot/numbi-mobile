using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMovement : MonoBehaviour{

    public float speed = 5f;

    void Update() {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

}
