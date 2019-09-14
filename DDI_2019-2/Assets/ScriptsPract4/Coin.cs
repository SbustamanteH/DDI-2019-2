using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Coin", menuName = "Inventario/Items/Coin")]
public class Coin : Item
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Usando item " + name);
    }
}
