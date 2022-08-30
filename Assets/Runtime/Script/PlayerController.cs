using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0.2f;
    [SerializeField] private float jumpSpeed = 0.5f;
    void Update()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
        }
    }
}
