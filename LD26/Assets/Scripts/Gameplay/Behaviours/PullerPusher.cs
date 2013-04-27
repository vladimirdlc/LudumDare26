using UnityEngine;
using System.Collections;

public class PullerPusher : MonoBehaviour
{
    private float currentElapsedTime;
    public float applyForceInSeconds = 0.1f;
    public float power = 500.0f;
    public Transform basePosition;
    public bool useMagnitude = true;

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (currentElapsedTime >= applyForceInSeconds)
        {
            Vector3 pullVector;

            pullVector = (basePosition.position - other.rigidbody.position).normalized;

            other.rigidbody.AddForce(pullVector * power);

            currentElapsedTime = 0;
        }
    }

    void FixedUpdate()
    {
        currentElapsedTime += Time.fixedDeltaTime;
    }
}
