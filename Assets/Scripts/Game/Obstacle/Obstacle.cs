using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _floatingBool;

    [SerializeField] private CharacterObstacleChecker _obstacleChecker;

    private void OnEnable()
    {
        _obstacleChecker.ObstacleDetected += OnObstacleDetected;
    }

    private void OnObstacleDetected()
    {
        _animator.SetBool(_floatingBool, false);
    }

    private void OnDisable()
    {
        _obstacleChecker.ObstacleDetected -= OnObstacleDetected;
    }
}