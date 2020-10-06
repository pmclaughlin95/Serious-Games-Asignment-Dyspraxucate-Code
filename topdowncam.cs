using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class topdowncam : MonoBehaviour
{
    public Transform m_Target;
    public float m_height = 15f;
    public float m_Distance = 7f;
    public float m_Angle = 180f;
    // Start is called before the first frame update
    void Start()
    {
        HandleCamera();  
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamera();
    }

    protected virtual void HandleCamera()
    {
        if (!m_Target)
        {
            return;
        }

        Vector3 WorldPosition = (Vector3.forward * m_Distance) + (Vector3.up * m_height);
        Debug.DrawLine(m_Target.position,WorldPosition,Color.green);

        Vector3 rotatedVector = Quaternion.AngleAxis(m_Angle, Vector3.up) * WorldPosition;
        Debug.DrawLine(m_Target.position, rotatedVector, Color.white);

        Vector3 flatTargetPosition = m_Target.position;
        flatTargetPosition.y = 0;
        Vector3 finalPosition = flatTargetPosition + rotatedVector;
        Debug.DrawLine(m_Target.position, rotatedVector, Color.red);

        transform.position = finalPosition;
        transform.LookAt(m_Target.position);
    }
}
