using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGuide : MonoBehaviour
{
    [SerializeField] private GameObject[] _guideTexts;

    [SerializeField] private Button _button;

    public event Action GuideCompleate;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        for (int i = 0; i < _guideTexts.Length; i++)
        {
            _guideTexts[i].SetActive(false);
        }

        GuideCompleate?.Invoke();
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }
}