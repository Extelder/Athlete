using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderBord : MonoBehaviour
{
    [SerializeField] private GameObject[] _you;

    [SerializeField] private TextMeshProUGUI[] _texts;
    [SerializeField] private int[] _coins;

    private int _currentCoinIndex;

    private bool _playerSetted;

    private void Start()
    {
        for (int i = 0; i < _texts.Length; i++)
        {
            if (_coins[i] <= PlayerPrefs.GetInt("Money") && _playerSetted == false)
            {
                _you[i].SetActive(true);
                _playerSetted = true;
                Debug.Log(PlayerPrefs.GetInt("Money"));
                _texts[i].text = PlayerPrefs.GetInt("Money").ToString();
            }
            else
            {
                _texts[i].text = _coins[_currentCoinIndex].ToString();
                _currentCoinIndex++;
            }
        }
    }
}