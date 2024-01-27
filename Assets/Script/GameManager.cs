using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform Level1RespawnPoint;
    [SerializeField] private Transform Level2RespawnPoint;
    [SerializeField] private Transform Level3RespawnPoint;
    [SerializeField] private Transform Level4RespawnPoint;

    [SerializeField] private NarratorsVoiceLinesSO _narratorsVoiceLinesSo;
    
    
    public Transform GetLeve1RP()
    {
        return Level1RespawnPoint;
    }
    public Transform GetLeve2RP()
    {
        return Level2RespawnPoint;
    }
    public Transform GetLeve3RP()
    {
        return Level3RespawnPoint;
    }
    public Transform GetLeve4RP()
    {
        return Level4RespawnPoint;
    }
    
    
}
