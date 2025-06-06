using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMoneyUI : MonoBehaviour
{
    [SerializeField] private GameWinMoney winMoney;

    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        winMoney.MoneyWinned += OnMoneyWinned;
    }

    private void OnMoneyWinned(int value)
    {
        _text.text = value.ToString();
    }

    private void OnDisable()
    {
        winMoney.MoneyWinned -= OnMoneyWinned;
    }
}