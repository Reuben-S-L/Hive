using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public GameObject resMan;


    public List<int> eventHolder;


    public float eventTimer;

    public float diceRoll;
    public Image roll1;
    public Image roll2;
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite dice4;
    public Sprite dice5;
    public Sprite dice6;
    public Button rollButton;

    public float chosenEvent;
    public int chosenEventIndex;
    public bool eventHappened;

    public float geltChange;
    public float fuelChange;
    public float populationChange;
    public float oxygenChange;
    public float weaponryChange;

    public GameObject popupManager;
    public GameObject popup;
    public Image popupImage;
    public Text popupText;


    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false);
        eventTimerSetter();
        eventHappened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (resMan.GetComponent<ResourcesManager>().days == eventTimer && eventHappened == false)
        {
            eventChooser();
            eventHappened = true;
            
            
        }
    }

    public void eventTimerSetter()
    {
        eventTimer += Random.Range(4, 30);
    }

    public void randomEventReturn()
    {
        resMan.GetComponent<ResourcesManager>().changeResources(geltChange, fuelChange, populationChange, oxygenChange, weaponryChange);

        geltChange = 0;
        populationChange = 0;
        oxygenChange = 0;
        weaponryChange = 0;
    }

    public void eventChooser()
    {
 
        chosenEventIndex = Random.Range(0, eventHolder.Count + 1);
        chosenEvent = eventHolder[chosenEventIndex];

        if (chosenEvent == 1)
        {
            popupManager.GetComponent<PopupManager>().OrcAttack();
        }
        if (chosenEvent == 2)
        {
            popupManager.GetComponent<PopupManager>().TyranidAttack();
        }
        if (chosenEvent == 3)
        {
            popupManager.GetComponent<PopupManager>().ChaosAttack();
        }
        if (chosenEvent == 4)
        {
            popupManager.GetComponent<PopupManager>().MutantAttack();
        }
        if (chosenEvent == 5)
        {
            popupManager.GetComponent<PopupManager>().TradeRouteAttacked();
        }
        if (chosenEvent == 6)
        {
            popupManager.GetComponent<PopupManager>().UnderhiveAttack();
        }
        if (chosenEvent == 7)
        {
            popupManager.GetComponent<PopupManager>().WorkerRevolt();
        }
        if (chosenEvent == 8)
        {
            popupManager.GetComponent<PopupManager>().InquisitorInspection();
        }
        if (chosenEvent == 9)
        {
            popupManager.GetComponent<PopupManager>().EcologicalCollapse();
        }
        if (chosenEvent == 10)
        {
            popupManager.GetComponent<PopupManager>().HeatsyncCollapse();
        }

        popup.SetActive(true);
    }


    public void setPopupTextAndImage(Text text, Image image)
    {

        popupImage = image;
        popupText = text;

    }

    public int rollDice()
    {
        int roll;

        roll = Random.Range(1, 7);

        return roll;
    }

    public void savingRoll()
    {

        diceRoll = 0;

        int rollOne = rollDice();

        diceRoll += rollOne;

        if(rollOne == 1)
        {
            roll1.sprite = dice1;
        }
        if (rollOne == 2)
        {
            roll1.sprite = dice2;
        }
        if (rollOne == 3)
        {
            roll1.sprite = dice3;
        }
        if (rollOne == 4)
        {
            roll1.sprite = dice4;
        }
        if (rollOne == 5)
        {
            roll1.sprite = dice5;
        }
        if (rollOne == 6)
        {
            roll1.sprite = dice6;
        }


        int rollTwo = rollDice();

        diceRoll += rollTwo;

        if (rollTwo == 1)
        {
            roll2.sprite = dice1;
        }
        if (rollTwo == 2)
        {
            roll2.sprite = dice2;
        }
        if (rollTwo == 3)
        {
            roll2.sprite = dice3;
        }
        if (rollTwo == 4)
        {
            roll2.sprite = dice4;
        }
        if (rollTwo == 5)
        {
            roll2.sprite = dice5;
        }
        if (rollTwo == 6)
        {
            roll2.sprite = dice6;
        }

        rollButton.interactable = false;

    }
}
