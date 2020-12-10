using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Event : ScriptableObject
{
    public string Description;

    public Sprite image;

    public int savingThrow;

    public int geltLoss;
    public int fuelLoss;
    public int populationLoss;
    public int oxygenLoss;
    public int weaponryLoss;

}
