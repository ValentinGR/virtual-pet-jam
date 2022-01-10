using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{

    #region Constructor

    public Rooms()
    {
        m_ROOM_HEIGHT = 10.5f;
        m_ROOM_WIDTH = 17.8f;
        nbrOfRoom = 3;
        xAxisNbrOfRoom = 3;
    }

    #endregion
    
  
    #region Methods

    public static float getRoomWidth()
    {
        return m_ROOM_WIDTH;
    }

    public static float getRoomHeight()
    {
        return m_ROOM_HEIGHT;
    }

    public static int getNbrOfRoom()
    {
        return nbrOfRoom;
    }

    public static int getxAxisNbrOfRoom()
    {
        return xAxisNbrOfRoom;
    }

    #endregion
  
  
    #region Arguments

    private static float m_ROOM_WIDTH;
    private static float m_ROOM_HEIGHT;

    private static int nbrOfRoom;
    private static int xAxisNbrOfRoom;

    #endregion
}
