using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MoveTowards : MonoBehaviour {

    // Private gameobjects to set at runtime
    GameObject coinAmountText;
    GameObject anchorPoint;
    // Speed at which the coins move
    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
        // Find our anchor
        anchorPoint = GameObject.FindGameObjectWithTag("Anchor");
        // Find our coin text
        coinAmountText = GameObject.FindGameObjectWithTag("CoinAmountText");
        // Randomize the speed of the coin a little bit to look better
        speed += UnityEngine.Random.Range(0.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
        // Move towards the anchor position
        transform.position = Vector3.MoveTowards(transform.position, anchorPoint.transform.position, speed * Time.deltaTime);
	}


    void OnCollisionEnter(Collision col)
    {
        // Check if we've collided with the anchor
        if (col.transform.tag == "Anchor")
        {
            // Get our old text amount
            int oldAmount = Convert.ToInt32(coinAmountText.GetComponent<Text>().text);
            // Increment it by one per collision, this could be an actual value if 
            // the coins were worth more than 1 per coin
            oldAmount++;
            // Set our amount string with the new amount
            coinAmountText.GetComponent<Text>().text = oldAmount.ToString();
            // Destroy the coin that hit the anchor
            Destroy(gameObject);
        }
    }
}
