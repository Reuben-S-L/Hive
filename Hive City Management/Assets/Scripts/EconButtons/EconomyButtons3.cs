using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// NUTRITION

public class EconomyButtons3 : MonoBehaviour
{

    public Text price;
    public GameObject economyScreen;
    public EventManager eventManager;

    public void Increase()
    {
        economyScreen.GetComponent<EconomyScreen>().buyUpgrade(int.Parse(price.text), 3);

        eventManager.eventHolder.Add(8); // ADDS AN INSTANCE OF THE INQUISITOR INSPECTION
    }
}
