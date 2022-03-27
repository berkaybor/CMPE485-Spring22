using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;
    public Camera mainCam;
    public Camera sideCam;
    private static int activeCam = 1;

    private void LateUpdate()
    {
        mainCam.transform.position = player.transform.position + new Vector3(0, 20, -10);
        sideCam.transform.position = player.transform.position + new Vector3(10.0f, 6.75f, -6.93f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(activeCam == 1)
            {
                mainCam.enabled = false;
                sideCam.enabled = true;
                activeCam = 2;
            } else
            {
                sideCam.enabled = false;
                mainCam.enabled = true;
                activeCam = 1;
            }
        }
    }
}
