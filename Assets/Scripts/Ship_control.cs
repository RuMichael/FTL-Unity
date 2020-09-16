using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_control : MonoBehaviour
{
    [SerializeField] int numOfFuel, numOfRocket, numOfDrones;
    [SerializeField] int bodyUnits, shildUnits;
    [SerializeField] int chanceToDodge;
    [SerializeField] List<ISystemUpgrade> Systems;
    [SerializeField] List<IWeapon> Weapons;
    [SerializeField] List<IPerson> Staff;
    [SerializeField] int maxSystems, maxWeapon, maxStaff;
    [SerializeField] int availableEnergy;
    // GameObject targetEnemy; нужно вынести в другой класс
    [SerializeField] List<Compartment> compartments;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
