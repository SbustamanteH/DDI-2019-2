using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ManaPotion", menuName = "Inventario/Items/Mana Potion")]
public class ManaPotion : Item
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Usando item " + name);
        Debug.Log("MP +100");
    }
}
