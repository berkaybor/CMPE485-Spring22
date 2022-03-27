using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioSource cry;
    public MeshRenderer meshToDisable;

    private void OnTriggerStay(Collider other)
    {
        if(Globals.collected == false)
        {
            if(other.tag == "Player")
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Globals.collected = true;
                    cry.Play();
                    meshToDisable.enabled = false;
                }
            }
        }
    }
}
