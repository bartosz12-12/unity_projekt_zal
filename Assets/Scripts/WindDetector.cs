using UnityEngine;

public class WindDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszed� na wind�.");

            // Zapami�tujemy obiekt gracza jako "starego rodzica"
            other.gameObject.transform.parent = transform.parent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszed� z windy.");

            // Przywracamy "starego rodzica" gracza
            other.gameObject.transform.parent = null;
        }
    }
}
