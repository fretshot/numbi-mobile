using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour{

    public Gameplay gameplay;

    public GameObject[] numbers;

    private float minTime = 5f;
    private float maxTime = 15f;

    void Start(){

        Invoke("instantiateNumber", Random.Range(minTime, maxTime));

    }

    void instantiateNumber() {

        int number = Random.Range(0, numbers.Length);

        Instantiate(numbers[number], transform.position, Quaternion.identity);

        gameplay.addNumbersToList(number+1);

        Invoke("instantiateNumber", Random.Range(minTime, maxTime));
    }

    public void stopNumberGenerator() {
        CancelInvoke();
    }


}
