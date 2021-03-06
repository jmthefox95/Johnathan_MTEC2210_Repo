using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speedMul = 1f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Input.GetAxis("Horizontal");
        float speed = Time.deltaTime * speedMul * xPos;

        rb.AddForce(Vector2.right * speed, ForceMode2D.Force);
        transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime) , transform.position.y, transform.position.z);
    }

}
