using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winda_dwa : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.0f;
    private Vector3 target;
    private Vector3 initialPosition;


    void Start()
    {
        initialPosition = transform.position;
        target = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z);
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
