using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon 
{
    int energyConsumption;
    int damageHull;
    int damageСreatures;
    float reloadTime;
    int cartridgeClip;

    delegate void MakeDamage(int damage);
    event MakeDamage Shot;
}
