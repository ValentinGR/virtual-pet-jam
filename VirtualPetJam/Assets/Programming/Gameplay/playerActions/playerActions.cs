using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerActions : MonoBehaviour
{
    #region Events

    public delegate void OnCreateMonster(Monster monster);
    public static event OnCreateMonster onCreateMonster;

    #endregion

    [HideInInspector]
    public static Monster myMonster;

    void Awake()
    {
        if (myMonster == null)
        {
            myMonster = new Monster();
            if (onCreateMonster != null)
                onCreateMonster(myMonster);
        }
    }
}
