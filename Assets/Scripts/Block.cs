using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / speed;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -2f)
		{
			Destroy(gameObject);
		}
	}

}
