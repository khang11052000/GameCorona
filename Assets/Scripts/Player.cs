using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D m_Rb;
    private Vector2 m_PlayerDirection;

    // Start is called before the first frame update
    void Start()
    {
        m_Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        m_PlayerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        m_Rb.velocity = new Vector2(0, m_PlayerDirection.y * playerSpeed);
    }
}
