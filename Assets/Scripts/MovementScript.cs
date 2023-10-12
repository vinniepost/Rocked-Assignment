using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float m_MovePower = 5;
    [SerializeField] private bool m_UseTorque = true;
    [SerializeField] private float m_MaxAngularVelocity = 25;

    private const float k_GroundRayLenght = 1f;
    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
    }
    public void Move(Vector3 moveDirection, bool propeler)
    {
        if (m_UseTorque)
        {
            m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x) * m_MovePower);
        }
        else
        {
            m_Rigidbody.AddForce(moveDirection * m_MovePower);
        }
        if (propeler)
        {
            m_Rigidbody.AddForce(Vector3.up);  
        }
    }
}

 
