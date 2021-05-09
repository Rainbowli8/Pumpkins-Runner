using UnityEngine;
using System.Collections;

public class Pumpkin : MonoBehaviour {
    public float moveForce = 10f;

    private Rigidbody myBody;

    // Use this for initialization

    void Awake() {
        myBody = GetComponent<Rigidbody> ();
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -10){
            Time.timeScale = 0f;
        }
	
	}

    void FixedUpdate() {
        MovePumpkin ();
    }

    void MovePumpkin() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        myBody.AddForce(new Vector3(h * moveForce, 0f, v * moveForce));
    }

    void OnTriggerEnter(Collider target) {
        if (target.tag == "Golem" || target.tag == "Gates") {
            Time.timeScale = 0f;
        }

    }
}
