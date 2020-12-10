using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backInfrastructure : MonoBehaviour
{

    public GameObject mainScreen;
    public GameObject InfrastructureScreen;

    public void back()
    {

        mainScreen.SetActive(true);
        InfrastructureScreen.SetActive(false);

    }
}
