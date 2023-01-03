using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    public Transform target; // The object that the ghost will follow
    public float speed = 1.0f; // The speed at which the ghost moves

    void Update()
    {
        // Calculate the direction from the ghost to the target
        Vector3 direction = target.position - transform.position;
        // Normalize the direction to get a unit vector
        direction.Normalize();
        // Move the ghost in the direction of the target at the specified speed
        transform.position += direction * speed * Time.deltaTime;
    }
}
