using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public PlayerControler playeer;
    public Camera gameCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameCamera.transform.position=new Vector3(
            Mathf.Lerp(gameCamera.transform.position.x, playeer.transform.position.x, 0.03f),
            playeer.transform.position.y,
            Mathf.Lerp(gameCamera.transform.position.z, playeer.transform.position.z-15, 0.03f)
        );
    }
}
