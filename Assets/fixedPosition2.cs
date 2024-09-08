using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedPosition2 : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = new Vector3(-0.0297f, player.position.y + 6.3f, transform.position.z);
    }
}
