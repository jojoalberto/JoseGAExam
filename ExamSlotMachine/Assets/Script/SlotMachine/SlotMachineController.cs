using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SlotMachineController : MonoBehaviour
{

    //private int[,] spinResult;
    private int[,] slotVal;
    [SerializeField] private int maxSlotRow;
    [SerializeField] private int maxSlotColumn;
    [SerializeField] private List<SlotSymbol> slotSymbols;
    [SerializeField] private SlotMachineDataManager slotMachineDataManager;
    [SerializeField] private PlayerData playerData;

    // Start is called before the first frame update
    void Start()
    {
        InputSlotSize(maxSlotRow, maxSlotColumn);
        playerData.playerCurrentBet = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InputSlotSize(int row, int column)
    {
        slotVal = new int[row, column];
    }

    public void RollResult()
    {
        if(playerData.playerCurrentMoney >= playerData.playerCurrentBet && playerData.playerCurrentBet != 0)
        {
            for (int rowResult = 0; rowResult < maxSlotRow; rowResult++)
            {
                for (int columnResult = 0; columnResult < maxSlotColumn; columnResult++)
                {
                    slotVal[rowResult, columnResult] = Random.Range(slotSymbols[0].number, slotSymbols[slotSymbols.Count - 1].number);
                }
            }
        }
       

        CheckResult();
        //for (int rowResult = 0; rowResult < maxSlotRow; rowResult++)
        //{
        //    for (int columnResult = 0; columnResult < maxSlotColumn; columnResult++)
        //    {
        //        Debug.Log("Array Result " + slotVal[rowResult, columnResult]);
        //    }
        //}

    }


    public void CheckResult()
    {
        //List<int> TempArray = new List<int>();
        //for (int rowResult = 0; rowResult < maxSlotRow; rowResult++)
        //{
        //    for (int columnResult = 0; columnResult < maxSlotColumn; columnResult++)
        //    {
        //        TempArray.Add(slotVal[rowResult, columnResult]);
        //    }
        //}
        //TempArray.Sort();
        int tempPoints = 0;
        bool hasDup = false;
        for (int rowResult = 0; rowResult < maxSlotRow; rowResult++)
        {
            for (int columnResult = 0; columnResult < maxSlotColumn; columnResult++)
            {
                for (int i = maxSlotRow - 1; i >= 0; i--)
                {
                    for (int x = maxSlotColumn -1; x >= 0; x--)
                    {
                        if (slotVal[rowResult, columnResult] == slotVal[i, x])
                        {
                            hasDup = true;
                        }
                    }
                }

                for (int z = 0; z < slotMachineDataManager.linePatternData.Count; z++)
                {
                    for (int c = 0; c < slotMachineDataManager.linePatternData[z].payoutLine.Count; c++)
                    {
                        for (int v = 0; v < slotMachineDataManager.linePatternData[z].payoutLine.Count; v++)
                        {

                            //if (slotVal[slotMachineDataManager.linePatternData[z].payoutLine[c], z] == slotVal[slotMachineDataManager.linePatternData[z].payoutLine[v], columnResult])
                            //{
                            //    if (hasDup)
                            //    {
                            //        tempPoints++;
                            //    }

                            //}
                        }
                    }
                }
            }
        }
        Debug.Log(tempPoints);


    }

}

