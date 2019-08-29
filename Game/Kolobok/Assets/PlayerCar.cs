using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
	[Range(0, 10)]
	public float speed = 1f;

	[Range(0, 10)]
	public float speedHor = 1f;

	public Vector2 topLeft;
	public Vector2 botRight;

	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			if (transform.position.y <= topLeft.y)
				transform.position += new Vector3(0, speed * Time.deltaTime, 0);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			if (transform.position.y >= botRight.y)
				transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
		}
		else
		{
			if (transform.position.y < 0)
				transform.position -= new Vector3(0, transform.position.y * speed / 3 * Time.deltaTime, 0);

			else
				transform.position -= new Vector3(0, transform.position.y * speed / 3 * Time.deltaTime, 0);
		}

		if (Input.GetKey(KeyCode.A))
		{
			if (transform.position.x >= topLeft.x)
				transform.position -= new Vector3(speedHor * Time.deltaTime, 0, 0);

			transform.eulerAngles = new Vector3(0, 0, +30);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			if (transform.position.x <= botRight.x)
				transform.position += new Vector3(speedHor * Time.deltaTime, 0, 0);

			transform.eulerAngles = new Vector3(0, 0, -30);
		}
		else
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
		}

	}
}
