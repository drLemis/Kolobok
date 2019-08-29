using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
	public GameObject enemy;

	// Start is called before the first frame update
	[Range(0, 0.01f)]
	public float rate = 1f;

	[Range(0, 10)]
	public float distance = 1f;

	[Range(-20, 20)]
	public float speed = 1f;

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Random.value < rate)
		{
			var temp = Instantiate(enemy);
			temp.transform.position = new Vector3(transform.position.x + Random.Range(-distance, distance), transform.position.y, 0);
			temp.GetComponent<EnemyMove>().speed = speed + Random.Range(-0.2f, 0.2f);

			Destroy(temp, 20f);
		}

	}
}
