using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public Transform checkpointVisual; // Arrastrá aquí el CheckPoint1 en el Inspector

    public static Vector3 currentCheckpointPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentCheckpointPosition = checkpointVisual.position;
            Debug.Log("Checkpoint activado en posición: " + currentCheckpointPosition);
        }
    }
}
