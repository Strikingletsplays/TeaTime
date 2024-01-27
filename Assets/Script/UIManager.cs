using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _pressEText;
    
    public void EnablePressEText()
    {
        _pressEText.gameObject.SetActive(true);
    }
    
    public void DisablePressEText()
    {
        _pressEText.gameObject.SetActive(false);
    }

    private void Awake()
    {
        DisablePressEText();
    }
}
