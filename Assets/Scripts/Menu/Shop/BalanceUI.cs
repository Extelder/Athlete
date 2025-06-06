using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BalanceUI : MonoBehaviour
{
    [SerializeField] private Balance _balance;
    [SerializeField] private TextMeshProUGUI _balanceText;

    private void OnEnable()
    {
        _balanceText.text = PlayerPrefs.GetInt("Money", _balance.StartBalance).ToString();
        _balance.BalanceChanged += ShowText;
    }

    private void ShowText()
    {
        _balanceText.text = _balance.CurrentBalance.ToString();
    }
    
    private void OnDisable()
    {
        _balance.BalanceChanged -= ShowText;
    }
}
