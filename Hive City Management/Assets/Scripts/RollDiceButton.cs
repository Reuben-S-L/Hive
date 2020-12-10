using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollDiceButton : MonoBehaviour
{

    public GameObject eventManager;
    public GameObject popupManager;

    public Text resultText;

    public Button okButton;


    public void diceButton()
    {
        eventManager.GetComponent<EventManager>().savingRoll();

        if(eventManager.GetComponent<EventManager>().diceRoll >= popupManager.GetComponent<PopupManager>().currentEvent.savingThrow)
        {

            resultText.text = "SUCCESS";

        }
        else
        {

            resultText.text = "FAILURE";

            eventManager.GetComponent<EventManager>().geltChange = popupManager.GetComponent<PopupManager>().currentEvent.geltLoss;
            eventManager.GetComponent<EventManager>().fuelChange = popupManager.GetComponent<PopupManager>().currentEvent.fuelLoss;
            eventManager.GetComponent<EventManager>().populationChange = popupManager.GetComponent<PopupManager>().currentEvent.populationLoss;
            eventManager.GetComponent<EventManager>().oxygenChange = popupManager.GetComponent<PopupManager>().currentEvent.oxygenLoss;
            eventManager.GetComponent<EventManager>().weaponryChange = popupManager.GetComponent<PopupManager>().currentEvent.weaponryLoss;


            eventManager.GetComponent<EventManager>().randomEventReturn();
        }

        okButton.interactable = true;

    }

}
