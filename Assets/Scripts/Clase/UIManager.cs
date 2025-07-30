using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtLevel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateMoneyTxt(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
    public void UpdatelevelTxt(string levelAmount)
    {
        txtLevel.text = levelAmount;
    }
}
