using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compartment : MonoBehaviour
{
    [SerializeField] ISystemUpgrade systemUpgrade = null;    
    [SerializeField] List<RectTransform> slots;
    [SerializeField] List<Door> doors;
    [SerializeField] List<IPerson> staff;
    int oxygen;

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    delegate void GetDamaged();
    event GetDamaged notifyDamage;
}
