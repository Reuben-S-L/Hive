using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmGuardsmen : MonoBehaviour
{

    public Text price;
    public GameObject armamentsScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {

        armamentsScreen.GetComponent<ArmamanetsScreen>().buyUpgrade(int.Parse(price.text), 1);

        popUp.orcAttack.savingThrow--;
        popUp.mutantAttack.savingThrow--;

        eventManager.eventHolder.Add(3);

    }
}
