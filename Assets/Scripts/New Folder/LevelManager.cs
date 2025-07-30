using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float level;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateLevelTxt(level.ToString());
    }

    public void UpdateMoney()
    {
      
        level += 1;
        uiManager.UpdateLevelTxt(level.ToString());
    }
}
