using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
    Vector2 baseDirection, currentMouse, smoothMouse;
	public float damping = 0.3f;
		
	// Use this for initialization
	void Start () {
		baseDirection = transform.rotation.eulerAngles;
	}
	
	void OnMouseDown() {
        Screen.lockCursor = true;
    }
	
	// Update is called once per frame
	void Update () {
		smoothMouse = Vector2.Lerp(smoothMouse, new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")), damping); 
		currentMouse += smoothMouse;
	}
}
