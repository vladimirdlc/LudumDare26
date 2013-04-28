using UnityEngine;
using System.Collections;

public class OnBreakBreakAnother : MonoBehaviour {
    public GameObject target;
    public float decreaseScaleAmount = 30;
    public string targetName = "Coraza";

    public void Start()
    {
        target = GameObject.Find(targetName);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (target != null && !collision.gameObject.tag.Equals(gameObject.tag))
        {
            target.transform.localScale -= new Vector3(decreaseScaleAmount, decreaseScaleAmount, decreaseScaleAmount);
            Destroy(gameObject);
        }
    }
}
