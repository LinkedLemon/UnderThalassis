using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D playerRigidBody;
    [SerializeField] private HealthManager playerHealth;
    [SerializeField] private TextMeshProUGUI HealthUi;
    private float playerInputVertical;
    private float playerInputHorizontal;

    [SerializeField] private float playerSpeed = 100.0f;
    [SerializeField] private float playerRotation = 100.0f;


    void Update()
    {
        playerInputVertical = Input.GetAxis("Vertical");
        playerInputHorizontal = Input.GetAxis("Horizontal");

        MovePlayer();
        RotatePlayer();
        IsPlayerRunning();

        HealthUi.text = playerHealth.ControllerHealth.ToString();
    }

    void MovePlayer()
    {
        float movementVector = (playerInputVertical * playerSpeed) * Time.deltaTime;


        playerRigidBody.AddForce(transform.up * movementVector, ForceMode2D.Impulse);
    }

    void RotatePlayer()
    {
        float roatationVector = (playerInputHorizontal * playerRotation) * Time.deltaTime;

        transform.Rotate(Vector3.back, roatationVector);
    }

    void IsPlayerRunning()
    {
        if (Input.GetButton("Fire3"))
        {
            playerSpeed = 250.0f;
        }
        else
        {
            playerSpeed = 100.0f;
        }
    }
}
