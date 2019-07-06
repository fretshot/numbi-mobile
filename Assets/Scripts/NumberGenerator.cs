using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour{

    public GameObject[] numbers;

    public float minTime = 2f;
    public float maxTime = 6f;

    void Start(){

        Invoke("instantiateNumber", Random.Range(minTime, maxTime));

    }

    void instantiateNumber() {

        int numero = Random.Range(0, numbers.Length);

        Instantiate(numbers[numero], transform.position, Quaternion.identity);

        Invoke("instantiateNumber", Random.Range(minTime, maxTime));
    }


}
