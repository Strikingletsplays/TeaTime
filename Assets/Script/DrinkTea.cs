using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkTea : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;

    private void OnTriggerStay(Collider other)
    {
        if (!other.TryGetComponent<InteractScript>(out var playerInteractScript)) return;
        _uiManager.EnablePressEText();
    }
    
    private void OnTriggerExit(Collider other)
    {
        _uiManager.DisablePressEText();
    }
}
