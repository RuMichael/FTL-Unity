using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWeapon : MonoBehaviour, ISystemUpgrade
{
    struct UpgrateSystem    // она будет отличаться, тк доп свойства у систем разные
    {
        internal int level;
        internal int upgradeCost;
        internal int energySize;
    }
    [SerializeField] int systemCost;
    [SerializeField] PrototypeSystems main;
    [SerializeField] List<UpgrateSystem> upgrateSystems = new List<UpgrateSystem>(); 

    void Start()
    {
        int count = 0;
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 0, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 10, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 15, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 30, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 40, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 60, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 80, energySize = ++count});
        upgrateSystems.Add(new UpgrateSystem{level = ++count, upgradeCost = 120, energySize = ++count});
    }
    void Update()
    {
        
    }

    public int GetCurrentLevel() => main.currentLevel;
    public int GetMaxLevel() => upgrateSystems.Count;
    public int GetUpgradeCost(int lvl)
    {
        int rezult = 0;
        foreach (var item in upgrateSystems)
            if (item.level == GetCurrentLevel() + 1){ rezult = item.upgradeCost; break; }
        return rezult;
    }
    public string GetLevelImprovementDescription(int lvl)
    {
        string rezult = "";
            foreach (var item in upgrateSystems)
                if (item.level == lvl){ 
                    rezult = $"Доступная энергия для оружия: +{item.energySize}";
                    break; 
                }
        return rezult;
    }
}
