using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void Pause()
    {
        Time.timeScale = 0;
        _pausePanel.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        _pausePanel.SetActive(false);
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }
}