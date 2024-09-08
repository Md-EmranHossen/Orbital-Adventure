using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedPosition : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = new Vector3(0, player.position.y + 6.3f, transform.position.z);
    }
}
