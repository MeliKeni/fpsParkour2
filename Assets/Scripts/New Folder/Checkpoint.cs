using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.UpdateCheckpoint(transform.position);
                Debug.Log("Checkpoint tocado, enviando al Player: " + transform.position);
            }
        }
    }
}