using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    float horizontal, vertical, jump;
    [SerializeField] float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        updateInputData();
        Vector3 position = new Vector3(horizontal, jump, vertical);
        rb.MovePosition(transform.position+ position * speed * Time.deltaTime);
    }

    void updateInputData()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");
    }
}
