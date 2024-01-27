using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class TeleportToLevel : MonoBehaviour
{
    [SerializeField] private Transform _teleportPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<CharacterController>(out var characterController)) return;
        characterController.enabled = false;
        characterController.transform.position = _teleportPosition.position;
        characterController.enabled = true;
    }
}
