using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// FUEL AQ

public class EconomyButtons1 : MonoBehaviour
{

    public Text price;
    public GameObject economyScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {
        economyScreen.GetComponent<EconomyScreen>().buyUpgrade(int.Parse(price.text), 1);

        popUp.mutantAttack.savingThrow++;
        popUp.ecologicalCollapse.savingThrow++;

    }
}
