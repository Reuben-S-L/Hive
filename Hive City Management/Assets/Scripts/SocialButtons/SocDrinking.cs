using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocDrinking : MonoBehaviour
{

    public Text price;
    public GameObject socialScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {

        socialScreen.GetComponent<SocialScreen>().buyUpgrade(int.Parse(price.text), 3);

        eventManager.eventHolder.Remove(7);
        eventManager.eventHolder.Add(8);



    }
}
