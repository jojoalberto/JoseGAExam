using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BetManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private PlayerData playerData;

    private int addBetAmount = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BetLimiter();
    }
    public void BetLimiter()
    {
        if(playerData.playerCurrentBet >= playerData.playerCurrentMoney)
        {
            playerData.playerCurrentBet = playerData.playerCurrentMoney;
        }
    }
    public void AddBet()
    {
        if (playerData.playerCurrentBet < playerData.playerCurrentMoney)
        {
            Debug.Log("hello");
            playerData.playerCurrentBet = playerData.playerCurrentBet + playerData.playerAddBet;
        }
        else 
        {
            playerData.playerCurrentBet = playerData.playerCurrentMoney;
        }
    }

    public void SubBet()
    {
        if (playerData.playerCurrentBet > 100)
        {
            playerData.playerCurrentBet = playerData.playerCurrentBet - playerData.playerSubBet;
        }
        else if (playerData.playerCurrentBet >= playerData.playerCurrentMoney)
        {
            playerData.playerCurrentBet = 100;
        }
    }
}
