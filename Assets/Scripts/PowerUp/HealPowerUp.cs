using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPowerUp : MonoBehaviour, BasePowerUp
{
    public GameObject player;
    PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            Apply();
            gameObject.SetActive(false);
        }
    }

    public void Apply()
    {
        playerHealth.ApplyPowerUp(30);
    }
}
