using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IWeaponDamageModifier;

public class WDMFire : IWeaponDamageModifier
{    
    void main()
    {
        chanceOfSuccessEvents = StatusSuccessEvents.Lower;
    }
}
