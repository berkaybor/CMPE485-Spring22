using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private CharacterController controller;
    [SerializeField] private float playerSpeed = 2.0f;

    public Canvas winScreen;
    public Canvas loseScreen;

    public AudioSource winAudio;
    public AudioSource loseAudio;

    private bool enableInput = true;

    public void GameLose()
    {
        loseAudio.Play();
        enableInput = false;
        loseScreen.enabled = true;
    }

    public void GameWin()
    {
        winAudio.Play();
        enableInput = false;
        winScreen.enabled = true;
    }

    public void TryAgainButton()
    {
        Globals.collected = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if(enableInput)
        {
            Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }
        }
        if(Globals.collected && transform.position.z <= 0 && enableInput == true)
        {
            // YOU WIN
            GameWin();
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        if (hit.gameObject.tag == "barrier")
        {
            // YOU LOSE
            GameLose();
        }
    }
}
