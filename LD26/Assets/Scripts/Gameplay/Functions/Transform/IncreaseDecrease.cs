using UnityEngine;
using System.Collections;

public class IncreaseDecrease : MonoBehaviour {
    public float minMagnitude = 0.001f, maxMagnitude = 10;
    public float decreaseRate = 0.4f, increseaRate = 0.8f;
    public bool isIncreasing = true;
    public float damping = 0.3f;
    public bool destroyOnMin = true;
    public bool destroyOnMax = false;
	
	void FixedUpdate () {
        Vector3 targetScale = this.transform.localScale *
            (isIncreasing ? increseaRate : -decreaseRate);
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.fixedDeltaTime * damping);

        isIncreasing = (isIncreasing ? transform.localScale.magnitude < maxMagnitude : transform.localScale.magnitude <= minMagnitude);

        if (destroyOnMin && transform.localScale.magnitude <= minMagnitude) Destroy(gameObject);
        if (destroyOnMax && transform.localScale.magnitude >= maxMagnitude) Destroy(gameObject); 
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
    }
}