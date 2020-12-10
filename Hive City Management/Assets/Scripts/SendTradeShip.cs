using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendTradeShip : MonoBehaviour
{

    public GameObject resourceManager;
    public GameObject popupMenu;

    public EventManager eventManager;


    public void sendSmallShipment()
    {
        if (resourceManager.GetComponent<ResourcesManager>().fuel > 100 && resourceManager.GetComponent<ResourcesManager>().population > 10 && resourceManager.GetComponent<ResourcesManager>().oxygen > 5 && resourceManager.GetComponent<ResourcesManager>().weaponry > 10)
        {

            resourceManager.GetComponent<ResourcesManager>().changeResources(200, -100, -10, -5, -10);

            eventManager.eventHolder.Add(1);
            eventManager.eventHolder.Add(2);
            eventManager.eventHolder.Add(5);
        }
    }

    public void sendMediumShipment()
    {
        if (resourceManager.GetComponent<ResourcesManager>().fuel > 450 && resourceManager.GetComponent<ResourcesManager>().population > 50 && resourceManager.GetComponent<ResourcesManager>().oxygen > 25 && resourceManager.GetComponent<ResourcesManager>().weaponry > 25)
        {


            resourceManager.GetComponent<ResourcesManager>().changeResources(800, -450, -50, -25, -25);

            eventManager.eventHolder.Add(1);
            eventManager.eventHolder.Add(2);
            eventManager.eventHolder.Add(5);
        }
    }

    public void sendLargeShipment()
    {
        if (resourceManager.GetComponent<ResourcesManager>().fuel > 750 && resourceManager.GetComponent<ResourcesManager>().population > 100 && resourceManager.GetComponent<ResourcesManager>().oxygen > 50 && resourceManager.GetComponent<ResourcesManager>().weaponry > 50)
        {


            resourceManager.GetComponent<ResourcesManager>().changeResources(1500, -750, -100, -50, -50);

            eventManager.eventHolder.Add(1);
            eventManager.eventHolder.Add(2);
            eventManager.eventHolder.Add(5);
        }
    }
}
