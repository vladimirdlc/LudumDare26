using UnityEngine;
using System.Collections;

public class PullerPusher : MonoBehaviour
{
    private float currentElapsedTime;
    public float applyForceInSeconds = 0.0f;
    public float power = 500.0f;
    public Transform basePosition;
    public bool isMagnitudeRelative = true;
    public bool isPullingToCenter = false;
    private bool isPassed = false;
    public static float speedBonus = 1;
    public float maxVelocity = 2, maxVelocityPlayer = 1;

    void OnTriggerStay(Collider other)
    {
        if (!isPassed && currentElapsedTime >= applyForceInSeconds)
        {
            Vector3 pullVector;

            if (isPullingToCenter) pullVector = (basePosition.position - other.rigidbody.position).normalized;
            else pullVector = transform.forward;

            if (isMagnitudeRelative) other.rigidbody.AddForce(pullVector * power * other.transform.localScale.magnitude * speedBonus);
            else other.rigidbody.AddForce(pullVector * power);

            currentElapsedTime = 0;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.rigidbody.velocity = Vector3.ClampMagnitude(other.rigidbody.velocity, maxVelocityPlayer);
        }
        else
        {
            other.rigidbody.velocity = Vector3.ClampMagnitude(other.rigidbody.velocity, maxVelocity);
        }
    }

    void FixedUpdate()
    {
        currentElapsedTime += Time.fixedDeltaTime;
    }
}
