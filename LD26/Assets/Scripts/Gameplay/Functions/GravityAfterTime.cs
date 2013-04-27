using UnityEngine;
using System.Collections;

public class GravityAfterTime : MonoBehaviour
{
    private float currentTimeAlive;
    public float afterTime = 5.0f;
    public bool isInFutureGravitable = false;

    void Update()
    {
        currentTimeAlive += Time.deltaTime;

        if (currentTimeAlive > afterTime)
        {
            rigidbody.useGravity = true;
            Destroy(this);
        }
    }
}