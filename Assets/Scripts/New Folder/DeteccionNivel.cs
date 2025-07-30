using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionNivel: MonoBehaviour
{
    
        public LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    
    void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.name == "Player")
    {
    levelManager.UpdateLevel(+1);
    Destroy(gameObject);
    }
}
}
