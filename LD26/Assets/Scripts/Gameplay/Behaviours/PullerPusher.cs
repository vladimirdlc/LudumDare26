using UnityEngine;
using System.Collections;

public class PullerPusher : MonoBehaviour {

    private float currentElapsedTime;
    public float applyForceInSeconds = 0.1f;
    public float power = 500.0f;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (currentElapsedTime >= applyForceInSeconds)
        {
            float distance = Mathf.Abs(transform.position.y - other.rigidbody.position.y);

            Vector3 pullVector;

            pullVector = (transform.position - other.rigidbody.position).normalized;

            other.rigidbody.AddForce(pullVector * power);

            currentElapsedTime = 0;

        }
    }
}
