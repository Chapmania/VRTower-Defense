using UnityEngine;
using System.Collections.Generic;

public class ZombieEnemyControl : MonoBehaviour
{


    private float m_moveSpeed = 0.5f;
    private float m_turnSpeed = 200;

    [SerializeField] private Animator m_animator;
    [SerializeField] private Rigidbody m_rigidBody;


    private float m_currentV = 10;

    private readonly float m_interpolation = 10;

    private Vector3 m_currentDirection = Vector3.zero;

    void Awake()
    {
        if (!m_animator) { gameObject.GetComponent<Animator>(); }
        if (!m_rigidBody) { gameObject.GetComponent<Animator>(); }
    }

    void FixedUpdate()
    {
        TankUpdate();
    }

    private void TankUpdate()
    {


        transform.position += transform.forward * m_moveSpeed * Time.deltaTime;

        m_animator.SetFloat("MoveSpeed", m_currentV);
    }


}
