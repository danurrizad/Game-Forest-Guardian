using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Kecepatan gerakan pemain
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // Menghitung vektor gerakan berdasarkan input
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed;
        // Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;

        // Menggerakkan pemain menggunakan Rigidbody
        rb.velocity = movement;

    }
}
