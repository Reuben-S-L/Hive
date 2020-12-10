using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncEnvironment : MonoBehaviour
{

    public Text price;
    public GameObject infrastructureScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {

        infrastructureScreen.GetComponent<InfrastructureScreen>().buyUpgrade(int.Parse(price.text), 3);

        eventManager.eventHolder.Remove(9);
        popUp.mutantAttack.savingThrow--;

    }
}
