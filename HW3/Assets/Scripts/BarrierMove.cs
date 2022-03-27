using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMove : MonoBehaviour
{
    private bool isOpen = false;
    private bool isMoving = false;

    private float minOpen = 1.0f;
    private float maxOpen = 2.5f;
    private float minClose = 1.0f;
    private float maxClose = 5.0f;

    private void Start()
    {
        if(Globals.difficulty == 2)
        {
            minOpen = 0.2f;
            maxOpen = 0.5f;
            minClose = 0.5f;
            maxClose = 0.8f;
        }
    }

    void Update()
    {
        if (!isMoving)
        {
            isMoving = true;
            if (isOpen)
            {
                StartCoroutine(Close());
            }
            else
            {
                StartCoroutine(Open());
            }
        }
    }

    IEnumerator Open()
    {
        while (transform.position.y <= 6)
        {
            transform.position += new Vector3(0, 0.1f, 0);
            yield return null;
        }
        yield return new WaitForSeconds(Random.Range(minOpen, maxOpen));
        isOpen = true;
        isMoving = false;
    }

    IEnumerator Close()
    {
        while (transform.position.y >= 3)
        {
            transform.position -= new Vector3(0, 0.1f, 0);
            yield return null;
        }
        yield return new WaitForSeconds(Random.Range(minClose, maxClose));
        isOpen = false;
        isMoving = false;
    }
}
