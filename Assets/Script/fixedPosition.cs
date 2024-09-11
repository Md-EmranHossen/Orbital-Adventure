using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedPosition : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        // Fixing the position based on the player's Y position
        transform.position = new Vector3(transform.position.x, player.position.y + 6.1f, transform.position.z);
    }
}
