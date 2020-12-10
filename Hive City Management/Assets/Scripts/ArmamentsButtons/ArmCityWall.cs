using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmCityWall : MonoBehaviour
{

    public Text price;
    public GameObject armamentsScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {

        armamentsScreen.GetComponent<ArmamanetsScreen>().buyUpgrade(int.Parse(price.text), 2);

        popUp.tyranidAttack.savingThrow--;
        popUp.chaosAttack.savingThrow--;

    }
}
