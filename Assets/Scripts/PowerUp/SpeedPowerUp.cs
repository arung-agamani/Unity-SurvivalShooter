using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour, BasePowerUp
{
    public GameObject player;
    PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
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
        playerMovement.ApplyPowerUp("Speed");
    }
}
