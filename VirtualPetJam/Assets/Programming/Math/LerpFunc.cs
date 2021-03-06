using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LerpFunc : MonoBehaviour
{

    #region Methods

    public void StartLerping(float lerpDuration, Vector3 startPosition, Vector3 endPosition, Transform target)
    {
        m_isLerping = true;
        m_timeLerpStarted = Time.time;
        m_lerpDuration = lerpDuration;

        m_startPosition = startPosition;
        m_endPosition = endPosition;

        m_transformTarget = target;
    }

    void FixedUpdate()
    {
        if (m_isLerping)
            CalculNextFramePosition();
    }

    void CalculNextFramePosition()
    {
        float timeSinceLerpStarted = Time.time - m_timeLerpStarted;
        float percentageCompletion = timeSinceLerpStarted / m_lerpDuration;

        m_transformTarget.position = Vector3.Lerp(m_startPosition, m_endPosition, percentageCompletion);
        
        if (percentageCompletion >= 1f)
            m_isLerping = false;
    }

    #endregion

    #region Variables

    private float m_lerpDuration;
    private float m_timeLerpStarted;

    private Vector3 m_startPosition;
    private Vector3 m_endPosition;


    private bool m_isLerping = false;

    private Transform m_transformTarget;

    #endregion
}
