using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinEquipable : MonoBehaviour
{
    [SerializeField] private Item _item;
    [SerializeField] private GameObject _equipButton;
    [SerializeField] private GameObject _lockImage;
    [SerializeField] private GameObject _arrow;
    [SerializeField] private SkinEquip _skinEquip;

    [SerializeField] private bool _canEquip;

    private void Start()
    {
        if (!_canEquip)
        {
            _canEquip = PlayerPrefs.GetInt(_item.Key + _item.ID + "Bought", 0) == 1;
        }
        if (_canEquip)
        {
            OnUnlocked();
        }
        if (PlayerPrefs.GetInt(_item.Key + "Skin", 0) == _item.ID)
        {
            _skinEquip.ChooseStartEquipable(this);
            Equip();
        }
    }

    private void OnUnlocked()
    {
        _equipButton.SetActive(true);
        if (_lockImage != null)
        {
            _lockImage.SetActive(false);
        }
    }

    public void Equip()
    {
        if (_canEquip)
        {
            _arrow.SetActive(true);
            PlayerPrefs.SetInt(_item.Key + "Skin", _item.ID);
        }
    }

    public void UnEquip()
    {
        _arrow.SetActive(false);
    }
}