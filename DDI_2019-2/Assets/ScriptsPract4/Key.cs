using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Key", menuName = "Inventario/Items/Key")]
public class Key : Item
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Usando item " + name);
        Debug.Log("Nada que desbloquear");
    }
}
