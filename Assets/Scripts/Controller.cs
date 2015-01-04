using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    // Prefabs for our master coin and smaller coins
    public GameObject coinPrefab;
    public GameObject masterCoin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Left mouse button down
        if (Input.GetMouseButtonDown(0))
        {
            // Draw a ray to the mouse position on screen
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if our ray has hit something up to a distance of 20 from the camera
            if (Physics.Raycast(ray, out hit, 20.0f))
            {
                // Spawn some coins
                coinSpawn(hit.transform);
                // Destroy the object we clicked
                Destroy(hit.transform.gameObject);
            }
        }

        // Right mouse button down
        if (Input.GetMouseButtonDown(1))
        {
            // Mouse position in a Vector3 so we can set its Z position
            Vector3 mousePos = Input.mousePosition;
            // We want 10 away from the camera
            mousePos.z = 10.0f; 

            // Set a new vector3 to the screen to world point of our mouse position
            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            // Instantiate a new master coin at the mouse cursor
            Instantiate(masterCoin, objectPos, masterCoin.transform.rotation);
        }
	}

    // This will spawn coins once a master coin has been clicked
    void coinSpawn(Transform coin)
    {
        // Setup a tmpCoin gameobject so we can change its color
        GameObject tmpCoin;

        // Spawn a number of coins, this is based on the value of the master coin
        for (int i = 0; i < coin.GetComponent<Coin>().coinValue; i++)
        {
            // Instantiate a coin at the master coin position
            tmpCoin = Instantiate(coinPrefab, coin.transform.position + new Vector3(Random.Range(-.5f, .5f), Random.Range(-.5f, .5f), 0), coinPrefab.transform.rotation) as GameObject;
            tmpCoin.renderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
