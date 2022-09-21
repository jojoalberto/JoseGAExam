using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UINumberManager : MonoBehaviour
{

    public TextMeshProUGUI textBet;
    public TextMeshProUGUI textCurrentMoney;
    [SerializeField] private PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerData();
    }

    public void UpdatePlayerData()
    {
        textCurrentMoney.text = playerData.playerCurrentMoney.ToString();
        textBet.text = playerData.playerCurrentBet.ToString();
    }
}
