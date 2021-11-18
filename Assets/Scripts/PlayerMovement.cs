using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float SpeedMul = 1f;
    private Rigidbody2D rb;

    public GameObject playerPig;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<RigidBody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }


        Debug.Log("Update running.");

    }

}
