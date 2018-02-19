using UnityEngine;
using System.Collections;

public class fireballDestroy : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Obstacle")) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}

