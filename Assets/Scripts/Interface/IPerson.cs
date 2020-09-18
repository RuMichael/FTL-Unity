using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPerson 
{
    int GetExperience();//опыт
    int GetLevel();
    int GetHeals();     //здоровье
    int MakeDamage();   // нанести урон
    int Renovate();     //ремонт
    void SpecialAbility();

}
