using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenButtons : MonoBehaviour
{

    public GameObject screenController;


    public void LoadEconomy()
    {

        screenController.GetComponent<screenController>().LoadEconomy();

    }

    public void LoadInfrastructure()
    {

        screenController.GetComponent<screenController>().LoadInfrastructure();

    }

    public void LoadTrade()
    {

        screenController.GetComponent<screenController>().LoadTrade();

    }

    public void LoadArmaments()
    {

        screenController.GetComponent<screenController>().LoadArmaments();

    }

    public void LoadSocial()
    {

        screenController.GetComponent<screenController>().LoadSocial();

    }




}
