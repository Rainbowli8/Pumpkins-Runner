using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    private Transform pumpkinPos;

    private float zDistance = 10f;
    private float yDistance = 4f;

	// Use this for initialization
	void Awake () {
        pumpkinPos = GameObject.Find("Pumpkin").transform;

	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = transform.position;
        temp.y = pumpkinPos.position.y + yDistance;
        temp.z = pumpkinPos.position.z - zDistance;
        transform.position = temp;
	}
}















