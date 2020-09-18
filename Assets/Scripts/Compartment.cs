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
        oxygen = 100;
    }
    void Update()
    {
        
    }

    internal delegate void GetDamaged();
    internal event GetDamaged notifyDamage;

    //огонь и дыры обрабатываются тут

}
