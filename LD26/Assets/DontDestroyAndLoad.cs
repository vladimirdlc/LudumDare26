using UnityEngine;
using System.Collections;

public class DontDestroyAndLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        Application.LoadLevel("Level01");
	}
}
