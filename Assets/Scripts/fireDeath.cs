using UnityEngine;

public class fireDeath: MonoBehaviour
{
    public string playerTag = "Player";
    public Transform teleportTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            TeleportPlayer(other.transform);
        }
    }

    private void TeleportPlayer(Transform playerTransform)
    {
        playerTransform.position = teleportTarget.position;
    }
}