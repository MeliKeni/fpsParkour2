using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){ //Es una funcion que ya existe, es par apenas se tocan, tenes OnCollisionExit que es apenas termina y OnCollisionStay
        Destroy(gameObject); // gameObject hace referencia al objeto que tiene el script asignado 
        Destroy(collision.gameObject); //como tenes el collision.gameObject estas eliminando el objeto con el que colisiona
    } 
}
