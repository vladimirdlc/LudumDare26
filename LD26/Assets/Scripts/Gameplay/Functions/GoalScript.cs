using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
    public string sceneToLoad;

    void OnTriggerEnter(Collider other)
    {
        BonusGame.portalLover++;
        Application.LoadLevel(sceneToLoad);
    }
}
