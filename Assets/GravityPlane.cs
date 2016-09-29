using UnityEngine;
using System.Collections;

public class GravityPlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        GravityPlayer player = col.GetComponent<GravityPlayer>();
        if (player != null && player.current != this)
        {
            //col.transform.up = transform.up;
            Vector3 right = Vector3.Cross(col.transform.up, transform.up);

            col.transform.rotation = Quaternion.AngleAxis(90, right) * col.transform.rotation;

            player.current = this;
        }
    }

    void OnTriggerExit(Collider col)
    {
        GravityPlayer player = col.GetComponent<GravityPlayer>();
        if (player != null && player.current == this)
        {
            player.current = null;
        }
    }
}
