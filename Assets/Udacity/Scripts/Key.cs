using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;
	public bool isKeyCollected = false;
	public AudioSource KeyCollectedPlayer;

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
		
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy
		isKeyCollected = true;
		KeyCollectedPlayer.GetComponent<AudioSource>().Play();
		Object.Instantiate(keyPoof, transform.position, Quaternion.identity);
		Destroy(gameObject);



	

	}

}
