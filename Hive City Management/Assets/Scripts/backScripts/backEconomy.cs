using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backEconomy : MonoBehaviour
{

    public GameObject mainScreen;
    public GameObject economyScreen;

    public void back()
    {

        mainScreen.SetActive(true);
        economyScreen.SetActive(false);

    }
}
