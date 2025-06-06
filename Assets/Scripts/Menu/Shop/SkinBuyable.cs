using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinBuyable : MonoBehaviour
{
    [SerializeField] private Item _item;
    [SerializeField] private GameObject _priceText;
    [SerializeField] private Balance _balance;

    private bool _bought;

    private void Start()
    {
        if (PlayerPrefs.GetInt(_item.Key + _item.ID + "Bought", 0) == 1 )
        {
            _bought = true;
            OnUnlocked();
        }
    }

    private void OnUnlocked()
    {
        _priceText.SetActive(false);
    }

    public void TryBuy()
    {
        if (_balance.CurrentBalance < _item.Price || _bought)
        {
            return;
        }
        OnUnlocked();
        _bought = true;
        _balance.SpendMoney(_item.Price);
        PlayerPrefs.SetInt(_item.Key + _item.ID + "Bought", 1);
    }
}
