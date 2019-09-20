using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "HealthPotion", menuName = "Inventario/Items/Health Potion")]
public class HealthPotion : Item
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Usando item " + name);
        Debug.Log("HP +100");
    }
}
