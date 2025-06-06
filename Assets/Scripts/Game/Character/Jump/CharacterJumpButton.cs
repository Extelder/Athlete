using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterJumpButton : MonoBehaviour
{
    [SerializeField] private Button _jumpButton;
    [SerializeField] private PowerArrowFloating _powerArrow;
    [SerializeField] private CharacterJump _jump;

    private void OnEnable()
    {
        _powerArrow.ArrowStopped += OnArrowStopped;
        _jump.JumpStarted += OnJumpStarted;
    }

    private void OnJumpStarted()
    {
        _jumpButton.gameObject.SetActive(false);
    }

    private void OnArrowStopped()
    {
        _jumpButton.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        _powerArrow.ArrowStopped -= OnArrowStopped;
        _jump.JumpStarted -= OnJumpStarted;
    }
}