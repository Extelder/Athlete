using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour
{
    [SerializeField] private GameObject _loseCanvas;

    [SerializeField] private CharacterObstacleChecker _obstacleChecker;

    public event Action Losed;

    private void OnEnable()
    {
        _obstacleChecker.ObstacleDetected += OnObstacleDetected;
    }

    private void OnObstacleDetected()
    {
        Lose();
    }

    private void Lose()
    {
        _loseCanvas.SetActive(true);
        Losed?.Invoke();
    }

    private void OnDisable()
    {
        _obstacleChecker.ObstacleDetected -= OnObstacleDetected;
    }
}