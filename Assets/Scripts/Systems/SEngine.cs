using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEngine : MonoBehaviour, ISystemUpgrade
{    
    struct UpgrateSystem    // она будет отличаться, тк доп свойства у систем разные
    {
        internal int level;
        internal int upgradeCost;
        internal int evasionModifier;
        internal float ftlDriveModifier;
    }
    [SerializeField] int systemCost;
    [SerializeField] PrototypeSystems main;
    [SerializeField] List<UpgrateSystem> upgrateSystems = new List<UpgrateSystem>(); 

    void Start()
    {
        int count = 0;
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 0, evasionModifier = 5, ftlDriveModifier = 1f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 10, evasionModifier = 10, ftlDriveModifier = 1.25f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 15, evasionModifier = 15, ftlDriveModifier = 1.5f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 30, evasionModifier = 20, ftlDriveModifier = 1.75f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 40, evasionModifier = 25, ftlDriveModifier = 2f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 60, evasionModifier = 28, ftlDriveModifier = 2.25f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 80, evasionModifier = 31, ftlDriveModifier = 2.5f});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 120, evasionModifier = 35, ftlDriveModifier = 2.75f});
    }
    void Update()
    {
        
    }
    IPerson SystemManager{ get => main.systemManager; set => main.systemManager = value; }

#region update
    public int GetCurrentLevel() => main.currentLevel;
    public int GetMaxLevel() => upgrateSystems.Count;
    public int GetUpgradeCost(int lvl){
        int rezult = 0;
        foreach (var item in upgrateSystems)
            if (item.level == GetCurrentLevel() + 1){ rezult = item.upgradeCost; break; }
        return rezult;
    }
    public string GetLevelImprovementDescription(int lvl){
        string rezult = "";
            foreach (var item in upgrateSystems)
                if (item.level == lvl){ 
                    rezult = $"Уклонение: +{item.evasionModifier}% / ССД: {item.ftlDriveModifier,2:D}х";
                    break; 
                }
        return rezult;
    }    
    
#endregion
    int GetLevelEvasionModifier(int lvl){
        int rezult = 0;
            foreach (var item in upgrateSystems)
                if (item.level == lvl){ rezult = item.evasionModifier; break; }
        return rezult;
    }
    float GetLevelFtlDriveModifier(int lvl){
        float rezult = 0f;
            foreach (var item in upgrateSystems)
                if (item.level == lvl){ rezult = item.ftlDriveModifier; break; }
        return rezult;
    }    

}
