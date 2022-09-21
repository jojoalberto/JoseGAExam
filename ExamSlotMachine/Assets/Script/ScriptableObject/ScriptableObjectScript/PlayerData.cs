using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "CreatePlayerData")]
public class PlayerData : ScriptableObject
{
    public int playerCurrentMoney;
    public int playerCurrentBet;
    public int playerWinnings;
    public int playerAddBet;
    public int playerSubBet;
}
