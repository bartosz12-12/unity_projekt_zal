using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public float x;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(1, 11);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (x == 1 || x == 2 || x == 10)
            {
                other.transform.position = new Vector3(-13, 84, -11);
            }
            else
            {
                other.transform.position = new Vector3(-32, 1, 11);
            }

        }
    }
}
