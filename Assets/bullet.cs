using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 position = this.transform.position;
        position.x = position.x - 0.1f;
        this.transform.position = position;
	}



}
