using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{

    public Event currentEvent;

    public Event orcAttack;
    public Event tyranidAttack;
    public Event chaosAttack;
    public Event mutantAttack;
    public Event tradeRouteAttacked;
    public Event underhiveAttack;
    public Event workerRevolt;
    public Event inquisitorInspection;
    public Event ecologicalCollapse;
    public Event heatsyncCollapse;

    public Image image;
    public Text description;
    public Text savingThrow;
    public Button okButton;


    public void displayEvent()
    {
        okButton.interactable = false;
        image.sprite = currentEvent.image;
        description.text = currentEvent.Description;
        savingThrow.text = currentEvent.savingThrow.ToString();

    }

    public void OrcAttack()
    {
        currentEvent = orcAttack;
        displayEvent();
    }

    public void TyranidAttack()
    {
        currentEvent = tyranidAttack;
        displayEvent();
    }

    public void ChaosAttack()
    {
        currentEvent = chaosAttack;
        displayEvent();
    }

    public void MutantAttack()
    {
        currentEvent = mutantAttack;
        displayEvent();
    }

    public void TradeRouteAttacked()
    {
        currentEvent = tradeRouteAttacked;
        displayEvent();
    }

    public void UnderhiveAttack()
    {
        currentEvent = underhiveAttack;
        displayEvent();
    }

    public void WorkerRevolt()
    {
        currentEvent = workerRevolt;
        displayEvent();
    }

    public void InquisitorInspection()
    {
        currentEvent = inquisitorInspection;
        displayEvent();
    }

    public void EcologicalCollapse()
    {
        currentEvent = ecologicalCollapse;
        displayEvent();
    }

    public void HeatsyncCollapse()
    {
        currentEvent = heatsyncCollapse;
        displayEvent();
    }
}
