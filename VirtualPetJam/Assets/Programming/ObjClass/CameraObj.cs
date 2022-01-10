using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObj : LerpFunc
{
    #region Constructor

    // Constructor

    public void CameraObjConstructor(Vector3 basePos, int baseRoom)
    {
        m_currentPos = basePos;
        m_desiredPos = basePos;
        m_currentRoom = baseRoom;
        m_transform = Camera.main.gameObject.transform;
    }

    #endregion


    #region Methods

    // public Methods

    public void MoveCamera(Vector2 direction)
    {
        Vector3 target = new Vector3(direction.x * Rooms.getRoomWidth(), direction.y * Rooms.getRoomHeight(), 0);
        StartLerping(0.3f, m_transform.position, m_transform.position + target, m_transform);
    }

    public Vector2 ChangeRoom(Vector2 direction)
    {
        m_currentRoom += (int)direction.x;

        if (m_currentRoom < 1)
        {
            direction = new Vector2(Rooms.getxAxisNbrOfRoom() - 1, Rooms.getNbrOfRoom() / Rooms.getxAxisNbrOfRoom() - 1);
            m_currentRoom = Rooms.getNbrOfRoom();
            return direction;
        }
        if (m_currentRoom > Rooms.getNbrOfRoom())
        {
            direction = new Vector2(-Rooms.getxAxisNbrOfRoom() + 1, -(Rooms.getNbrOfRoom() / Rooms.getxAxisNbrOfRoom()) + 1);
            m_currentRoom = 1;
            return direction;
        }

        direction = new Vector2(direction.x, 0);
        /*m_currentRoom += (int)direction.y * Rooms.getxAxisNbrOfRoom();

        if (m_currentRoom < 1)
        {
            direction = new Vector2(0, Rooms.getNbrOfRoom() * Rooms.getxAxisNbrOfRoom());
            m_currentRoom = (int)direction.y * Rooms.getxAxisNbrOfRoom();
        }
        if (m_currentRoom > Rooms.getNbrOfRoom())
        {

        }*/
        return direction;
    }

    #endregion

    #region Arguments

    // private Arguments

    private Vector3 m_currentPos;
    private Vector3 m_desiredPos;

    private int m_currentRoom;
    private Transform m_transform;

    #endregion
}
