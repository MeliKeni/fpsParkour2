using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Vector3 lastCheckpointPosition;

    void Start()
    {
        lastCheckpointPosition = transform.position; // posición inicial por si no tocó ningún checkpoint aún
    }

    void Update()
    {
        if (transform.position.y < -30)
        {
            transform.position = lastCheckpointPosition;
            Debug.Log("Jugador respawneado en: " + lastCheckpointPosition);
        }
    }

    public void UpdateCheckpoint(Vector3 newCheckpoint)
    {
        lastCheckpointPosition = newCheckpoint;
        Debug.Log("Checkpoint actualizado en el jugador: " + lastCheckpointPosition);
    }
}
