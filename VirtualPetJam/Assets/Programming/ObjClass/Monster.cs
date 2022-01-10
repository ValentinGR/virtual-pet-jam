using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    #region Constructor

    public Monster()
    {
        m_mood = -5;
        m_hunger = 3;
        m_relationship = 0;
        m_knowledge = 0;

        m_sleepingTimer = 0;
        m_airMeter = 100;
    }

    #endregion

    #region Events

    public delegate void OnUpdateHunger(short hunger);
    public event OnUpdateHunger onUpdateHunger;

    public delegate void OnUpdateMood(short mood);
    public event OnUpdateMood onUpdateMood;

    public delegate void OnUpdateKnowledge(short knowledge);
    public event OnUpdateKnowledge onUpdateKnowledge;

    public delegate void OnUpdateRelationship(short relationship);
    public event OnUpdateRelationship onUpdateRelationship;

    #endregion


    #region Methods

        #region changeMethods

    public void changeMood(short currentValue)
    {
        m_mood += currentValue;

        if (m_mood > 10)
            m_mood = 10;
        else if (m_mood < -10)
            m_mood = -10;

        if (onUpdateMood != null)
            onUpdateMood(m_mood);
    }

    public void changeHunger(short currentValue)
    {
        m_hunger += currentValue;

        if (m_hunger > 3)
            m_hunger = 3;
        else if (m_hunger < -3)
            m_hunger = -3;

        if (onUpdateHunger != null)
            onUpdateHunger(m_hunger);
    }

    public void changeKnowledge(short currentValue)
    {
        m_knowledge += currentValue;

        if (m_knowledge > 25)
            m_knowledge = 25;
        else if (m_knowledge < 0)
            m_knowledge = 0;

        if (onUpdateKnowledge != null)
            onUpdateKnowledge(m_knowledge);
    }

    public void changeRelationship(short currentValue)
    {
        m_relationship += currentValue;

        if (m_relationship > 15)
            m_relationship = 15;
        else if (m_relationship < -15)
            m_relationship = -15;

        if (onUpdateRelationship != null)
            onUpdateRelationship(m_relationship);
    }
        #endregion

        #region getMethods

    public short getMood()
    {
        return m_mood;
    }

    public short getHunger()
    {
        return m_hunger;
    }

    public short getKnowledge()
    {
        return m_knowledge;
    }

    public short getRelationship()
    {
        return m_relationship;
    }

        #endregion

    #endregion


    #region Arguments

    private short m_mood;
    private short m_hunger;
    private short m_knowledge;
    private short m_relationship;

    private float m_sleepingTimer;
    private float m_airMeter;

    #endregion
}