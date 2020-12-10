using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backArmaments : MonoBehaviour
{

    public GameObject mainScreen;
    public GameObject armamentsScreen;

    public void back()
    {

        mainScreen.SetActive(true);
        armamentsScreen.SetActive(false);

    }
}
