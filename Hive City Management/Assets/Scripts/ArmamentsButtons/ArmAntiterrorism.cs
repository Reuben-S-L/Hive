using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmAntiterrorism : MonoBehaviour
{

    public Text price;
    public GameObject armamentsScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {

        armamentsScreen.GetComponent<ArmamanetsScreen>().buyUpgrade(int.Parse(price.text), 4);

        eventManager.eventHolder.Remove(6);
        eventManager.eventHolder.Remove(7);

    }
}
