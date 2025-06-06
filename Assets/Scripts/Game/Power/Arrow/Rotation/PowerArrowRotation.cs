using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class PowerArrowRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private CompositeDisposable _disposable = new CompositeDisposable();

    public void StartRotation()
    {
        _disposable?.Clear();
        Observable.EveryUpdate().Subscribe(_ =>
        {
            transform.Rotate(transform.forward * _rotationSpeed * Time.deltaTime, Space.Self);
        }).AddTo(_disposable);
    }

    public void StopRotation()
    {
        _disposable?.Clear();
    }

    private void OnDisable()
    {
        _disposable?.Clear();
    }
}