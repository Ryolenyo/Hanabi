﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_movement : MonoBehaviour {

	float speed = 5;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.back * Time.deltaTime * speed);
	}
}
