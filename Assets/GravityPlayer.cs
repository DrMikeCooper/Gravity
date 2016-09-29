using UnityEngine;
using System.Collections;

public class GravityPlayer : MonoBehaviour {

    public GravityPlane current;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position
            + 0.1f * transform.right * Input.GetAxis("Horizontal")
            + 0.1f * transform.forward * Input.GetAxis("Vertical");

        transform.rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse X"), transform.up) * transform.rotation;
	}
}
