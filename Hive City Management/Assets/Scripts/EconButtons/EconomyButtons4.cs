using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// WEAPONS AQ

public class EconomyButtons4 : MonoBehaviour

 {

    public Text price;
    public GameObject economyScreen;
    public PopupManager popUp;

    public void Increase()
    {
        economyScreen.GetComponent<EconomyScreen>().buyUpgrade(int.Parse(price.text), 4);

        popUp.ecologicalCollapse.savingThrow++;
    }
}

