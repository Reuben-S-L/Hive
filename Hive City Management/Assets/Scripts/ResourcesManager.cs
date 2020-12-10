using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesManager : MonoBehaviour
{

    public GameObject economyScreen;

    public float dayLength;

    public float gelt;
    public float geltRate;

    public float fuel;
    public float fuelRate;

    public float population;
    public float populationRate;

    public float oxygen;
    public float oxygenRate;

    public float weaponry;
    public float weaponryRate;

    public bool distressBeacon;

    public float days;

    public float time;
    public float dayChecker;

    public Text geltDisplay;
    public Text fuelDisplay;
    public Text populationDisplay;
    public Text oxygenDisplay;
    public Text weaponryDisplay;
    public Text daysDisplay;


    // Start is called before the first frame update
    void Start()
    {
        gelt = 10000;
        fuel = 1000;
        population = 100;
        oxygen = 10;
        weaponry = 1;
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        dayChecker += Time.deltaTime;

        if(dayChecker >= dayLength)
        {
            days++;
            dayChecker = 0;

            changeResources(economyScreen.GetComponent<EconomyScreen>().fLevel * 10, economyScreen.GetComponent<EconomyScreen>().fLevel*8, economyScreen.GetComponent<EconomyScreen>().oLevel * 8, economyScreen.GetComponent<EconomyScreen>().nLevel * 8, economyScreen.GetComponent<EconomyScreen>().wLevel * 6);
        }

        updateHudDisplay();

    }

    public void changeResources(float gel, float ful, float pop, float ox, float weap) // FOR ADDING OR TAKING AWAY RESOURCES
    {
        gelt += gel;
        fuel += ful;
        population += pop;
        oxygen += ox;
        weaponry += weap;
    }

    public void updateHudDisplay()
    {
        geltDisplay.text = gelt.ToString();
        fuelDisplay.text = fuel.ToString();
        populationDisplay.text = population.ToString();
        oxygenDisplay.text = oxygen.ToString();
        weaponryDisplay.text = weaponry.ToString();
        daysDisplay.text = days.ToString();
    }




}
