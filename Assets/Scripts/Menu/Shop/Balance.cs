using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    [field: SerializeField] public int StartBalance { get; set; }
    public int CurrentBalance { get; private set; }
    public event Action BalanceChanged;


    private void Start()
    {
        CurrentBalance = PlayerPrefs.GetInt("Money", StartBalance);
    }

    public void SpendMoney(int price)
    {
        if (CurrentBalance - price < 0)
        {
            return;
        }
        CurrentBalance -= price;
        BalanceChanged?.Invoke();
        PlayerPrefs.SetInt("Money", CurrentBalance);
    }
    
    public void EarnMoney(int gain)
    {
        CurrentBalance += gain;
        BalanceChanged?.Invoke();
        PlayerPrefs.SetInt("Money", CurrentBalance);
    }
}
