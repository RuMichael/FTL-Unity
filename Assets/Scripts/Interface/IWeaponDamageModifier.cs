using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IWeaponDamageModifier 
{
    //internal StatusSuccessEvents chanceOfSuccessEvents;
    public enum StatusSuccessEvents : int
    {
        Lower = 15, 
        Medium = 30,
        Higt = 45   
    }
    //тут должен быть метод который как то воздействует на отсек, в которое прошло попадание
}
