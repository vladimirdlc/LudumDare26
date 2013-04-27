using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public int fireButton = 0;
	
	public float fullCharge = 1000.0f;
	public float chargeSpeed = 100;
	public GameObject bullet;
	public Material chargerMaterial;
	
	bool isCharging = false;
	bool isShooting = false;
	float shootPower;
	
	float noCharge = 0;
	
	// Update is called once per frame
	void Update () {
		float chargeColor;
		
		if(!isShooting)
		{
			if(Input.GetMouseButtonDown(fireButton)) isCharging = true;
			else if(Input.GetMouseButtonDown(fireButton)) 
			{
				isCharging = false;
				//shoot
				shootPower = 0;
				chargerMaterial.color = Color.white;
			}
			
			if(isCharging)
			{
				shootPower += Time.deltaTime * chargeSpeed;
				shootPower = Mathf.Clamp(shootPower, noCharge, fullCharge);
				chargeColor = shootPower/fullCharge;
				chargerMaterial.color = Color.Lerp(Color.white, Color.red, chargeColor);
			}
		}
	}
}
