using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObj : MonoBehaviour
{
    #region Constructor

    // Constructor

    CameraObj(Vector3 basePos, int baseRoom)
    {
        m_currentPos = basePos;
        m_desiredPos = basePos;
        m_currentRoom = baseRoom;
        m_transform = Camera.main.gameObject.transform;

        lerpClass = new LerpFunc();
    }

    #endregion


    #region Methods

    // public Methods

    void MoveCamera(Vector3 direction)
    {
        lerpClass.StartLerping(0.3f, m_transform.position, m_transform.position + direction, m_transform);
    }

    #endregion

    #region Arguments

    // private Arguments

    private Vector3 m_currentPos;
    private Vector3 m_desiredPos;

    private int m_currentRoom;
    private Transform m_transform;

    private LerpFunc lerpClass;

    #endregion
}
