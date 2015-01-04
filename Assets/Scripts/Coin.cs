using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public int coinValue = 5;

	// Use this for initialization
	void Start () {
        coinValue += Random.Range(0, 15);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.skin.label.alignment = TextAnchor.MiddleCenter;
        Vector3 p = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        GUI.Label(new Rect(p.x - 26, Screen.height - p.y - 26, 50, 50), "" + coinValue);
    }
}
