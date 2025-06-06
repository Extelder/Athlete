using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinMoney : MonoBehaviour
{
    [SerializeField] private int _moneyPerWin = 15;

    [SerializeField] private GameWin _win;

    public event Action<int> MoneyWinned;

    private int _money;

    private void OnEnable()
    {
        _win.Winned += OnWinned;
    }

    private void OnWinned()
    {
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + _moneyPerWin);
        MoneyWinned?.Invoke(_moneyPerWin);
    }

    private void OnDisable()
    {
        _win.Winned -= OnWinned;
    }
}