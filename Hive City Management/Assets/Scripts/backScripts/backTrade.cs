using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backTrade : MonoBehaviour
{

    public GameObject mainScreen;
    public GameObject tradeScreen;

    public void back()
    {

        mainScreen.SetActive(true);
        tradeScreen.SetActive(false);

    }
}
