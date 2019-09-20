using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Bomb", menuName = "Inventario/Items/Bomb")]
public class Bomb3D: Item
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Usando item " + name);
        Debug.Log("Ruuuuun");
    }
}
