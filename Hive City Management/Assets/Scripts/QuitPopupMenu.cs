using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitPopupMenu : MonoBehaviour
{

    public GameObject popUp;
    public GameObject eventManager;
    public GameObject rollDiceButton;

    public Sprite diceDefault;


        public void hidePopup()
    {

        eventManager.GetComponent<EventManager>().eventTimerSetter();
        eventManager.GetComponent<EventManager>().eventHappened = false;

        // RESET TEXT AND ROLL BUTTON TO INTERACTABLE HERE - REFRENCE ROLL DICE BUTTON

        eventManager.GetComponent<EventManager>().roll1.sprite = diceDefault;
        eventManager.GetComponent<EventManager>().roll2.sprite = diceDefault;

        eventManager.GetComponent<EventManager>().diceRoll = 0;

        rollDiceButton.GetComponent<RollDiceButton>().resultText.text = "OUTCOME";

        eventManager.GetComponent<EventManager>().rollButton.interactable = true;



        popUp.SetActive(false);


    }

}
