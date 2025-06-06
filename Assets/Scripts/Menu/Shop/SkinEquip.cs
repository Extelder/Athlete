using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinEquip : MonoBehaviour
{
    private SkinEquipable _currentEquipable;

    public void Equip(SkinEquipable skinEquipable)
    {
        _currentEquipable?.UnEquip();
        _currentEquipable = skinEquipable;
        skinEquipable.Equip();
    }

    public void ChooseStartEquipable(SkinEquipable equipable)
    {
        if (_currentEquipable == null)
        {
            _currentEquipable = equipable;
        }
    }
}
