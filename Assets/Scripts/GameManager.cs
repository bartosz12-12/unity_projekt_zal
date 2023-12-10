using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI hightText;
    public float time = 0;
    public GameObject player;
    public bool friz = false;
    public float frizTime = 0;
    public finish finish;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (friz == false && finish.end == false)
        {
            timeText.color = Color.white;
            time += Time.deltaTime;
            timeText.text = "Time: " + Mathf.CeilToInt(time);
            hightText.text = "Hight: " + Mathf.CeilToInt(player.transform.position.y);
            Debug.Log("dzia³a");
        }
        if (friz == true)
        {
            timeText.color = Color.blue;
            timeText.text = "Time: " + Mathf.CeilToInt(time);
            hightText.text = "Hight: " + Mathf.CeilToInt(player.transform.position.y);
            frizTime += Time.deltaTime;
            Debug.Log("zamro¿ony");
            if (frizTime > 15)
            {
                friz = false;
                frizTime = 0;
            }
        }
        if (finish.end == true)
        {
            timeText.color = Color.yellow;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            friz = true;
        }

    }
}
