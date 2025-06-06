using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionArrowFloating : MonoBehaviour
{
    [SerializeField] private PowerArrowFloating _arrowFloating;

    [SerializeField] private Button _characterPanelButton;

    [SerializeField] private Animator _animator;
    [SerializeField] private string _floatingBool;

    private void OnEnable()
    {
        _characterPanelButton.onClick.AddListener(StopFloating);
    }

    private void OnDisable()
    {
        _characterPanelButton.onClick.RemoveListener(StopFloating);
    }

    public void StopFloating()
    {
        _animator.SetBool(_floatingBool, false);
        _arrowFloating.StartFloating();
    }
}