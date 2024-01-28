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

    Queue<AudioClip> clipQueue = new Queue<AudioClip>();
    
    [SerializeField] private AudioSource _audioSource;

    public bool AudioSourceIsPlaying()
    {
        return _audioSource.isPlaying;
    }
    private void Update()
    {
        if (_audioSource.isPlaying == false && clipQueue.Count > 0) {
            _audioSource.clip = clipQueue.Dequeue();
            _audioSource.Play();
        }
    }
    public void Enqueue(AudioClip audioClip)
    {
        clipQueue.Enqueue(audioClip);
    }
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
