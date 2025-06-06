using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    [SerializeField] private string _key;

    [SerializeField] private GameObject[] _skins;

    private void Awake()
    {
        _skins[PlayerPrefs.GetInt(_key, 0)].SetActive(true);
    }
}