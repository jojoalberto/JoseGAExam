using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LinePatternData
{
    public List<int> payoutLine;

}

public class SlotMachineDataManager : MonoBehaviour
{

    [SerializeField] public List<LinePatternData> linePatternData;

    //private int jockpotPos;
    //[SerializeField] private SlotMachineController slotMachineController;
    //[SerializeField] private int points;

    // Start is called before the first frame update

    
    //public List<LinePatternData> GetPatternChecker()
    //{
    //    return linePatternData;
    //    //slotMachineController.CheckResult(linePatterData, points);
    //}


    
}
