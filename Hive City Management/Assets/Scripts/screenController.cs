using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenController : MonoBehaviour
{

    

    public GameObject mainScreen;

    public GameObject EconomyScreen;

    public GameObject InfrastructureScreen;

    public GameObject TradeScreen;

    public GameObject ArmamentsScreen;

    public GameObject SocialScreen;

    // Start is called before the first frame update
    void Start()
    {
        EconomyScreen.SetActive(false);
        InfrastructureScreen.SetActive(false);
        TradeScreen.SetActive(false);
        ArmamentsScreen.SetActive(false);
        SocialScreen.SetActive(false);
    }


    public void LoadEconomy()
    {

        mainScreen.SetActive(false);

        EconomyScreen.SetActive(true);

    }

    public void LoadInfrastructure()
    {

        mainScreen.SetActive(false);

        InfrastructureScreen.SetActive(true);

    }

    public void LoadTrade()
    {

        mainScreen.SetActive(false);

        TradeScreen.SetActive(true);

    }

    public void LoadArmaments()
    {

        mainScreen.SetActive(false);

        ArmamentsScreen.SetActive(true);

    }

    public void LoadSocial()
    {

        mainScreen.SetActive(false);

        SocialScreen.SetActive(true);

    }
}
