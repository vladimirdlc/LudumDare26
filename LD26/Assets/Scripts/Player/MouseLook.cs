using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
    Vector2 baseDirection, currentMouse, smoothMouse;
	public float damping = 0.3f;
    public float speed = 2.0f;
		
	void Start () {
		baseDirection = transform.rotation.eulerAngles;
	}
	
	void OnMouseDown() {
        Screen.lockCursor = true;
    }
	
	void Update () {
		smoothMouse = Vector2.Lerp(smoothMouse, new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"))*speed, damping); 
		currentMouse += smoothMouse;
		
		transform.localRotation = Quaternion.AngleAxis(-currentMouse.y, Quaternion.Euler(baseDirection)*Vector3.right);
		transform.localRotation *= Quaternion.AngleAxis(currentMouse.x, transform.InverseTransformDirection(Vector3.up));
	}
}
