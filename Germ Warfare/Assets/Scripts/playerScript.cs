using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	private Rigidbody2D rb2d;

	public float speed;

	public float height;

	public GameObject fireball;
	public Transform fireballSpawn;
	public float fireRate;

	private float nextFire;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(fireball, fireballSpawn.position, fireballSpawn.rotation);
		}
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);
	}

	void OnTriggerEnter2D(Collider2D other) {
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag("Obstacle")) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
