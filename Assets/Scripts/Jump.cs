using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float gravityValue = -9.81f;
    private Vector3 playerVelocity;
    private float jumpHeight = 2f;
    private CharacterController controller;
    private bool isRunning = false;

    void Start()
    {
        playerVelocity.y = 0f;
    }

    void Update()
    {
        if (isRunning)
        {
            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
        }

        if (isRunning && controller.isGrounded)
        {
            isRunning = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            controller = other.GetComponent<CharacterController>();
            StartCoroutine(JumpRoutine());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("wyszed³");
        }
    }

    private IEnumerator JumpRoutine()
    {
        yield return new WaitUntil(() => Input.GetButtonDown("Jump"));

        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);

        isRunning = true;
    }
}
