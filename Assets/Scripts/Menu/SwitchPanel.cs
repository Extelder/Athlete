using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject _switchPanel;

    public void Switch()
    {
        _mainPanel.SetActive(false);
        _switchPanel.SetActive(true);
    }

    public void SwitchBack()
    {
        _mainPanel.SetActive(true);
        _switchPanel.SetActive(false);
    }
}
