using UnityEngine;
using System.Collections;

public class BonusGame : MonoBehaviour
{
    public GameObject sun;
    public Camera secondCamera;
    public GameObject harsHaterGO;
    public GameObject portalLoverGO;
    public GameObject totalBrokenGO;
    public bool isPaintedBlack = false;
    public static int totalBroken;
    public static int harsHater;
    public static int portalLover;

    void Start()
    {
        harsHaterGO.transform.localScale = new Vector3(harsHaterGO.transform.localScale.x, harsHaterGO.transform.localScale.y * (harsHater + 1),
            harsHaterGO.transform.localScale.z);
        portalLoverGO.transform.localScale = new Vector3(portalLoverGO.transform.localScale.x, portalLoverGO.transform.localScale.y * (portalLover + 1),
            totalBrokenGO.transform.localScale.z);
        totalBrokenGO.transform.localScale = new Vector3(totalBrokenGO.transform.localScale.x, totalBrokenGO.transform.localScale.y * (totalBroken + 1),
            totalBrokenGO.transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (sun == null && !isPaintedBlack)
        {
            isPaintedBlack = true;
            Camera.main.backgroundColor = Color.black;
            secondCamera.backgroundColor = Color.black;
        }
    }
}
