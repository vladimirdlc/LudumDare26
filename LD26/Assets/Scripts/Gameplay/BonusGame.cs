using UnityEngine;
using System.Collections;

public class BonusGame : MonoBehaviour {
    public GameObject sun;
    public Camera secondCamera;
    public bool isPaintedBlack = false;

	// Update is called once per frame
	void Update () {
        if (sun == null && !isPaintedBlack)
        {
            isPaintedBlack = true;
            Camera.main.backgroundColor = Color.black;
            secondCamera.backgroundColor = Color.black;
        }
	}
}
