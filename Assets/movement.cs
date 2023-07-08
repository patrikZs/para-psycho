using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class movement : MonoBehaviour
{
	Rigidbody2D player;
	float speed = 0.2f;
	// Start is called before the first frame update
	void Start()
    {
		player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		float x = 0, y = 0;
		if (Input.GetKey(KeyCode.W))
		{
			y += 1f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			x -= 1f;
		}
		if (Input.GetKey(KeyCode.S))
		{
			y -= 1f;
		}
		if (Input.GetKey(KeyCode.D))
		{
			x += 1f;
		}
		Vector3 move = new Vector3(x, y, 0);
		move.Normalize();
		player.MovePosition(transform.position + move * speed);
	}
}
