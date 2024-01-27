using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private UIManager _uiManager;
    public int Level = 0;

    [SerializeField] private Transform _teleportPoint;
    private void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.TryGetComponent<InteractScript>(out var playerInteractScript)) return;
        if(playerInteractScript.collectedItems == Level)
            _uiManager.EnablePressEText();
    }

    private void OnTriggerExit(Collider other)
    {
        _uiManager.DisablePressEText();
    }

    public int GetLevel()
    {
        return Level;
    }

    public Transform GetTeleportPoint()
    {
        return _teleportPoint;
    }
}
