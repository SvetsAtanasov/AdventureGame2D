using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject particles;

    public void SpawnParticles (Vector2 particlePosition)
    {
        Instantiate(particles, particlePosition, Quaternion.identity);
    }
}
