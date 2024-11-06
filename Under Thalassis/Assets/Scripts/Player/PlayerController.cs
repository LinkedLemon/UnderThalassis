using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D playerRigidBody;
    private float playerInputVertical;
    private float playerInputHorizontal;

    private float playerSpeed = 100.0f;
    private float playerRotation = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerInputVertical = Input.GetAxis("Vertical");
        playerInputHorizontal = Input.GetAxis("Horizontal");

        MovePlayer();
        RotatePlayer();
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
}
