using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public int coinValue = 5;

	// Use this for initialization
	void Start () {
		// Randomly increase the value of the coin
        coinValue += Random.Range(0, 20);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
		// Set the label color to black
        GUI.contentColor = Color.black;
		// Set the label alignment to MiddleCenter
        GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		// Pull our transform position to a point on the screen
        Vector3 p = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		// Draw our label on that new spot, centered on our coin
        GUI.Label(new Rect(p.x - 26, Screen.height - p.y - 26, 50, 50), "" + coinValue);
    }
}