using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects")]
public class Item : ScriptableObject
{
    [field: SerializeField] public int Price { get; private set; }
    [field: SerializeField] public int ID { get; private set; }
    [field: SerializeField] public string Key { get; private set; }
}
