using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	public bool locked=true;
	public AudioSource doorOpenedPlayer;
	public AudioSource doorLockedPlayer;
	public Key key;

    void Update() {
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up
		if (locked == false & transform.position.y < 18.5f ){
			//Debug.Log("open the door!"); 
			transform.Translate(0, 1f * Time.deltaTime, 0, Space.World);
			doorOpenedPlayer.GetComponent<AudioSource>().Play();
			}


	

    }

    public void Unlock()
    {
        // You'll need to set "locked" to true here
		if (key.isKeyCollected == true) {		    
			locked = false;
		}

		else {
			doorLockedPlayer.GetComponent<AudioSource>().Play();
		}


    }
}
