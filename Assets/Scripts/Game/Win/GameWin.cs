using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    [SerializeField] private GameObject _winCanvas;

    [SerializeField] private CharacterObstacleChecker _obstacleChecker;

    public event Action Winned;

    private void OnEnable()
    {
        _obstacleChecker.ObstacleAvoided += OnObstacleAvoided;
    }

    private void OnObstacleAvoided()
    {
        Win();
    }

    private void Win()
    {
        _winCanvas.SetActive(true);
        Winned?.Invoke();
    }

    private void OnDisable()
    {
        _obstacleChecker.ObstacleAvoided -= OnObstacleAvoided;
    }
}