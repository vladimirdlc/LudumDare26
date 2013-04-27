using UnityEngine;
using System.Collections;

public class PullerPusher : MonoBehaviour
{
    private float currentElapsedTime;
    public float applyForceInSeconds = 0.1f;
    public float power = 500.0f;
    public Transform basePosition;
    public bool isMagnitudeRelative = true;
    public bool isPullingToCenter = false;

    void OnTriggerStay(Collider other)
    {
        if (currentElapsedTime >= applyForceInSeconds)
        {
            Vector3 pullVector;

            if (isPullingToCenter) pullVector = (basePosition.position - other.rigidbody.position).normalized;
            else pullVector = transform.forward;

            if (isMagnitudeRelative) other.rigidbody.AddForce(pullVector * power * other.transform.localScale.magnitude);
            else other.rigidbody.AddForce(pullVector * power);

            currentElapsedTime = 0;
        }
    }

    void FixedUpdate()
    {
        currentElapsedTime += Time.fixedDeltaTime;
    }
}
