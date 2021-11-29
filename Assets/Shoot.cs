using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour { 

    public GameObject bullet;
    public float delay = 8;

    private float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.Mouse0) && counter > delay)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            counter = 0;
        }
        counter += Time.deltaTime; 
    }
}
