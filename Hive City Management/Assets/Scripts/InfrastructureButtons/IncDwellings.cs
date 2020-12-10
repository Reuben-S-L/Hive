using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IncDwellings : MonoBehaviour
{

    public Text price;
    public GameObject infrastructureScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {
        infrastructureScreen.GetComponent<InfrastructureScreen>().buyUpgrade(int.Parse(price.text), 1);

        eventManager.eventHolder.Remove(7);


    }
}
