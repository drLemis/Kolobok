using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	// Start is called before the first frame update
	[Range(0, 10)]
	public float speed = 1f;

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

	}
}
