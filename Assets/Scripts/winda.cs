using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UIElements;

public class winda : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.0f;
    private Vector3 target;
    private Vector3 initialPosition;
    private Transform oldParent;

    void Start()
    {
        initialPosition = transform.position;
        target = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszed³ na windê.");
            oldParent = other.gameObject.transform.parent;
            other.gameObject.transform.parent = transform;

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
