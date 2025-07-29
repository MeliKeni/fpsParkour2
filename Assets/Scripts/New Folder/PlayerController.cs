using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        // Si el jugador cae por debajo de Y = -30
        if (transform.position.y < -30f)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Teletransporta al jugador a la posición guardada en Checkpoint
        transform.position = CheckpointTrigger.currentCheckpointPosition;
        Debug.Log("Jugador reapareció en checkpoint.");
        
        // Opcional: si tienes Rigidbody, resetear velocidad
        Rigidbody rb = GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
