using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ShootObject : MonoBehaviour {

    public GameObject bullet;
    public GameObject pointerHitPoint;
    private GameObject clone;
    private Vector3 location;
    private Vector3 direction;
    

    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {

        createBullet();

    }
    void createBullet()
    {
        if (Input.GetKeyDown("space"))
        {

             if (clone != null)
             {
               Destroy(clone);
             }

            location = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, Camera.main.transform.position.z);

            clone = Instantiate(bullet, location, Quaternion.identity) as GameObject;
            direction = Camera.main.transform.forward;
        }
        if (clone != null)
        {
            clone.transform.Translate(direction * Time.deltaTime * 10);
        }
    }
   }
