using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// OXYGEN COLLECTION

public class EconomyButtons2 : MonoBehaviour
{

    public Text price;
    public GameObject economyScreen;
    public PopupManager popUp;

    public void Increase()
    {
        economyScreen.GetComponent<EconomyScreen>().buyUpgrade(int.Parse(price.text), 2);
        popUp.ecologicalCollapse.savingThrow++;
    }
}
