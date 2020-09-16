using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class PrototypeSystems : MonoBehaviour
{   
    [SerializeField] internal bool isSubsystem;       //тип
    [SerializeField] internal bool controlBonusCrew;    //бонус контроля экипажа    
    [SerializeField] internal int currentLevel;        //текущий уровень
    internal bool isControlBonusCrew{ get => (systemManager != null )? true : false; } //бонус экипажа активен?   
    internal IPerson systemManager;   
}
