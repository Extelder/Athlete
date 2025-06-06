using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCircle : MonoBehaviour
{
    [SerializeField] private GameWin _win;
    [SerializeField] private GameLose _lose;

    private void OnEnable()
    {
        _win.Winned += Disable;
        _lose.Losed += Disable;
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        _win.Winned -= Disable;
        _lose.Losed -= Disable;
    }
}