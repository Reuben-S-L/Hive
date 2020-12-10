using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocEducation : MonoBehaviour
{

    public Text price;
    public GameObject socialScreen;
    public PopupManager popUp;
    public EventManager eventManager;

    public void Increase()
    {

        socialScreen.GetComponent<SocialScreen>().buyUpgrade(int.Parse(price.text), 4);

        popUp.heatsyncCollapse.savingThrow--;
        eventManager.eventHolder.Add(7);

    }
}
