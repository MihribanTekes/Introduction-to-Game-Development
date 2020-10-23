
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class TriggerLevelLoad : MonoBehaviour {


    void OnCollisionEnter(Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// call the RestartGame function in the game manager
			GameManager.gm.NextLevel();
		}

        
	}
}
