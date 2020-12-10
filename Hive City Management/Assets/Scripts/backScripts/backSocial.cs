using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backSocial : MonoBehaviour
{

    public GameObject mainScreen;
    public GameObject socialScreen;

    public void back()
    {

        mainScreen.SetActive(true);
        socialScreen.SetActive(false);

    }
}
