using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{

	//Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;


    public void OnCoinClicked() {
		Debug.Log("You collect a coin!"+ coinPoof);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

		Object.Instantiate(coinPoof, transform.position, Quaternion.identity);
		Destroy (gameObject);
    }



	public void Start(){
		
	}
}
