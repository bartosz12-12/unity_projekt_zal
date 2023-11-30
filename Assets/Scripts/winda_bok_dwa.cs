using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winda_bok_dwa : MonoBehaviour
{
    private float speed = 10.0f;
    private Vector3 target;
    private Vector3 initialPosition;
    private Transform oldParent;



    void Start()
    {
        initialPosition = transform.position;
        target = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
    }

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszed³ na windê.");
            oldParent = other.gameObject.transform.parent;
            Debug.Log("oldparent" + oldParent);
            other.gameObject.transform.parent = transform;
            Debug.Log(other.gameObject.transform.parent);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszed³ z windy.");
            other.gameObject.transform.parent = null;
        }
    }
}
