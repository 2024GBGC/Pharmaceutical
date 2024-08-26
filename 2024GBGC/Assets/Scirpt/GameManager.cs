using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int credit;
    public ProductionLine productionLine1;
    public ProductionLine productionLine2;
    public ProductionLine productionLine3;

    private void Start()
    {
        RunningProductionLine(productionLine1);
    }

    public void IncreaseCredit(int price)
    {
        credit += price;
    }

    public void RunningProductionLine(ProductionLine productionLine)
    {
        productionLine.running = true;
        productionLine.button.GetComponent<Button>().interactable = true;
    }

    public void IncreaseProductionSpeed()
    {

    }
}
