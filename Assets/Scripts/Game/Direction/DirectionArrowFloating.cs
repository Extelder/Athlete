using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionArrowFloating : MonoBehaviour
{
    [SerializeField] private GameGuide _guide;

    [SerializeField] private PowerArrowFloating _arrowFloating;

    [SerializeField] private Button _characterPanelButton;

    [SerializeField] private Animator _animator;
    [SerializeField] private string _floatingBool;


    private void OnEnable()
    {
        _guide.GuideCompleate += OnGuideCompleate;
    }

    private void OnGuideCompleate()
    {
        _guide.GuideCompleate -= OnGuideCompleate;
        _characterPanelButton.onClick.AddListener(StopFloating);

        _animator.SetBool(_floatingBool, true);
    }

    private void OnDisable()
    {
        _characterPanelButton.onClick.RemoveListener(StopFloating);
        _guide.GuideCompleate -= OnGuideCompleate;
    }

    public void StopFloating()
    {
        _animator.SetBool(_floatingBool, false);
        _arrowFloating.StartFloating();
    }
}