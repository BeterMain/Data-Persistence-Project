using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public Rigidbody Ball;
    public float initialVelocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get random direction
        float randomDirection = Random.Range(-1.0f, 1.0f);
        Vector3 forceDir = new Vector3(randomDirection, 1, 0);
        forceDir.Normalize();

        // Send ball in direction
        Ball.AddForce(forceDir * initialVelocity, ForceMode.VelocityChange);
    }
}
