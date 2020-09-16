using System.Collections;
using System.Collections.Generic;
using UnityEngine;
internal class WorkWithSystemDamage
{
    public enum State { Serviceable, Defective, Broken}
    const int minHealth = 0, maxHealth = 100;
    int currentHealth = 100;
    void GetDamage(int val)
    {
        currentHealth = (currentHealth >= val) ? currentHealth - val : minHealth;
    }
    void getRepair(int val)
    {
        currentHealth = (currentHealth + val <= maxHealth) ? currentHealth + val : maxHealth;
    }
    
}