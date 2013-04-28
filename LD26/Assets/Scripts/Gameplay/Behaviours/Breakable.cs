using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour {
    public Color[] lifeColors;
    private int currentHits;
    private static string breakerTag = "Damager";

    // Use this for initialization
    void Start () {
    currentHits = 0;
    gameObject.renderer.material.color = lifeColors[0];
    }
        
    // Update is called once per frame
    public void hit () {
        if (++currentHits == lifeColors.Length) breakObject();
        else gameObject.renderer.material.color = lifeColors[currentHits];
    }

    public void breakObject()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == breakerTag)
        {
            hit();
        }
    }
}
