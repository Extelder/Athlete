using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerArrowFloating : MonoBehaviour
{
    [SerializeField] private Button _button;

    [SerializeField] private PowerArrowRotation _arrowRotation;

    public event Action ArrowStopped;

    public void StartFloating()
    {
        _arrowRotation.StartRotation();
        _button.onClick.AddListener(StopFloating);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(StopFloating);
    }

    private void StopFloating()
    {
        _arrowRotation.StopRotation();
        ArrowStopped?.Invoke();
        _button.onClick.RemoveListener(StopFloating);
    }
}