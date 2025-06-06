using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class CharacterObstacleChecker : MonoBehaviour
{
    [SerializeField] private Collider2D _characterCollider;

    [SerializeField] private CharacterJump _jump;

    private CompositeDisposable _disposable = new CompositeDisposable();

    public event Action ObstacleDetected;
    public event Action ObstacleAvoided;

    private void OnEnable()
    {
        _jump.JumpStarted += OnJumpStarted;
        _jump.JumpEnded += OnJumpEnded;
    }

    private void OnJumpStarted()
    {
        _characterCollider.OnTriggerEnter2DAsObservable().Subscribe(other =>
        {
            if (other.TryGetComponent<Obstacle>(out Obstacle Obstacle))
            {
                _jump.StopJumping();
                ObstacleDetected?.Invoke();
                _disposable.Clear();
            }
        }).AddTo(_disposable);
    }

    private void OnJumpEnded()
    {
        ObstacleAvoided?.Invoke();

        _disposable?.Clear();
    }


    private void OnDisable()
    {
        _disposable?.Clear();
        _jump.JumpStarted -= OnJumpStarted;
        _jump.JumpEnded -= OnJumpEnded;
    }
}