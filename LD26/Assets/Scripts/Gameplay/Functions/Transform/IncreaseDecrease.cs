using UnityEngine;
using System.Collections;

public class IncreaseDecrease : MonoBehaviour {
    public float minSize = 0f, maxSize = 10;
    public float decreaseRate = 0.4f, increseaRate = 0.8f;
    public bool isIncreasing = true;
    public float damping = 0.3f;
	
	void FixedUpdate () {
        Vector3 targetScale = this.transform.localScale *
            (isIncreasing ? increseaRate : -decreaseRate);
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.fixedDeltaTime * damping);
	}
}
