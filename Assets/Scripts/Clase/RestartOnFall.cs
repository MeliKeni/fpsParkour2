using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartOnFall : MonoBehaviour
{
public float alturaDeMuerte;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < alturaDeMuerte){//como el script esta en el mismo componente que el transform puedo directamente llamarlo usando el transform en minuscula
            SceneManager.LoadScene("FPSParkour");
        } 
    }
}
