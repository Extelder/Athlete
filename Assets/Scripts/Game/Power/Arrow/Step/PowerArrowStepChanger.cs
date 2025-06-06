using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerArrowStepChanger : MonoBehaviour
{
    public int CurrentStepNumber { get; private set; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<PowerArrowStep>(out PowerArrowStep powerArrowStep))
        {
            CurrentStepNumber = powerArrowStep.Step;
            Debug.Log(CurrentStepNumber);
        }
    }
}