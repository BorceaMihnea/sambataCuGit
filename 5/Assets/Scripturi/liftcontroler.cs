using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftcontroler : MonoBehaviour
{public float delta = 2.0f;
public float speed = 2.0f;
Vector3 ve;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ve.y=delta*Mathf.Sin(Time.time * speed);
        GetComponent<Rigidbody>().velocity = ve;
    }
}
