using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISystemUpgrade
{   
    int GetCurrentLevel();
    int GetMaxLevel();
    int GetUpgradeCost(int lvl);
    string GetLevelImprovementDescription(int lvl);

}

