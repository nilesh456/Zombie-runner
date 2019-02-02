using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour {

    [Tooltip("number of minute per second, try it 60")]
    public float minutePerSeconds;


	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360 * minutePerSeconds;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);

    }
}
