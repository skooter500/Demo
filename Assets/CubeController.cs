using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    int playerNum = 0;
    public GameObject bulletPrefab;
    public GameObject bulletSpawn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float f = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Horizontal");
        float power = 100;

        /*
        transform.Translate(0, 0, f * Time.deltaTime);

        transform.Rotate(0, r * Time.deltaTime * 100.0f, 0);
        */

        GetComponent<Rigidbody>().AddForce(transform.forward * f * Time.deltaTime * power);
        GetComponent<Rigidbody>().AddTorque(transform.up * r * Time.deltaTime * 20);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
            bullet.transform.position = bulletSpawn.transform.position;
            bullet.transform.rotation = this.transform.rotation;
        }
        
    }
}
