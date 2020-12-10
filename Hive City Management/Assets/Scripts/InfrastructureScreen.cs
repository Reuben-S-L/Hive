using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfrastructureScreen : MonoBehaviour
{

    public GameObject resourcesManager;

    public float fLevel;
    public float oLevel;
    public float nLevel;
    public float wLevel;

    public float fPrice;
    public float oPrice;
    public float nPrice;
    public float wPrice;

    public Text fLevelText;
    public Text oLevelText;
    public Text nLevelText;
    public Text wLevelText;

    public Text fPriceText;
    public Text oPriceText;
    public Text nPriceText;
    public Text wPriceText;


    void Start()
    {
        fPrice = int.Parse(fPriceText.text);
        oPrice = int.Parse(oPriceText.text);
        nPrice = int.Parse(nPriceText.text);
        wPrice = int.Parse(wPriceText.text);

        fLevel = int.Parse(fLevelText.text);
        oLevel = int.Parse(oLevelText.text);
        nLevel = int.Parse(nLevelText.text);
        wLevel = int.Parse(wLevelText.text);

    }


    // AMEND SAVING ROLLS DEPENDING ON THE LEVELS OF THESE 

    public void buyUpgrade(float price, float resourceToIncrease)
    {
        if (price < resourcesManager.GetComponent<ResourcesManager>().gelt)
        {
            resourcesManager.GetComponent<ResourcesManager>().gelt -= price;

            if (resourceToIncrease == 1)
            {
                fLevel++;
                fPrice = (fPrice * 2f);
            }
            if (resourceToIncrease == 2)
            {
                oLevel++;
                oPrice = oPrice * 2f;
            }
            if (resourceToIncrease == 3)
            {
                nLevel++;
                nPrice = nPrice * 2f;
            }
            if (resourceToIncrease == 4)
            {
                wLevel++;
                wPrice = wPrice * 2f;
            }

        }

        updateScreen();

    }

    public void updateScreen()
    {

        fLevelText.text = fLevel.ToString();
        oLevelText.text = oLevel.ToString();
        nLevelText.text = nLevel.ToString();
        wLevelText.text = wLevel.ToString();

        fPriceText.text = fPrice.ToString();
        oPriceText.text = oPrice.ToString();
        nPriceText.text = nPrice.ToString();
        wPriceText.text = wPrice.ToString();

    }

}
