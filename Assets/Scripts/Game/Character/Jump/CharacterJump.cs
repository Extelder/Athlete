using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    [SerializeField] private float _speedFactor = 6;

    [SerializeField] private PowerArrowStepChanger _powerArrowStepChanger;

    [SerializeField] private Transform _point;

    private Tween _moveTween;

    public event Action JumpStarted;
    public event Action JumpEnded;

    public void Jump()
    {
        JumpStarted?.Invoke();
        _moveTween = transform.DOMove(_point.position, _powerArrowStepChanger.CurrentStepNumber / _speedFactor)
            .OnComplete((() => { JumpEnded?.Invoke(); }));
    }

    public void StopJumping()
    {
        _moveTween?.Kill();
    }

    private void OnDisable()
    {
        _moveTween?.Kill();
    }
}