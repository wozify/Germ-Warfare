using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
	public float life;

	void Start ()
	{
		Destroy (gameObject, life);
	}
}

