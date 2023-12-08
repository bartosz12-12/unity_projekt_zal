using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frizz : MonoBehaviour
{
    public bool friz = false;
    private float frizTime = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (friz == true)
        {
            frizTime += Time.deltaTime;
            Debug.Log("zamro¿ony");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            friz = true;
        }
        if (frizTime == 15)
        {
            friz = false;
            frizTime = 0;
        }

    }
}
