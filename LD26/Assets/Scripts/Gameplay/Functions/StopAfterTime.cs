using UnityEngine;
using System.Collections;

public class StopAfterTime : MonoBehaviour
{
    private float currentTimeAlive;
    public float afterTime = 5.0f;

    void Update()
    {
        currentTimeAlive += Time.deltaTime;

        if (currentTimeAlive > afterTime)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.useGravity = false;
            Destroy(this);
        }
    }
}