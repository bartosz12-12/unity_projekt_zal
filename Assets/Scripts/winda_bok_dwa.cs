using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winda_bok_dwa : MonoBehaviour
{
    private float speed = 10.0f;
    private Vector3 target;
    private Vector3 initialPosition;


    void Start()
    {
        initialPosition = transform.position;
        target = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (transform.position == target)
        {
            Vector3 temp = target;
            target = initialPosition;
            initialPosition = temp;
        }
    }
}
