using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRendering : MonoBehaviour
{
    #region Event Subscription

    void OnEnable()
    {
        playerActions.onCreateMonster += SetMonster;
        feedingAction.onUpdateFood += UpdateFood;
    }

    void OnDisable()
    {
        playerActions.onCreateMonster -= SetMonster;

        m_currentMonster.onUpdateHunger -= UpdateHunger;
        m_currentMonster.onUpdateMood -= UpdateMood;
        m_currentMonster.onUpdateKnowledge -= UpdateKnowledge;
        m_currentMonster.onUpdateRelationship -= UpdateRelationship;

        feedingAction.onUpdateFood -= UpdateFood;
    }

    #endregion

    Monster m_currentMonster;

    #region Text References

    Text hungerText;
    Text foodText;
    Text moodText;
    Text knowledgeText;
    Text relationshipText;

    #endregion

    void Start()
    {
        hungerText = GameObject.Find("HungerText").GetComponent<Text>();
        UpdateHunger(m_currentMonster.getHunger());

        foodText = GameObject.Find("FoodText").GetComponent<Text>();
        UpdateFood(5);

        moodText = GameObject.Find("MoodText").GetComponent<Text>();
        UpdateMood(m_currentMonster.getMood());

        knowledgeText = GameObject.Find("KnowledgeText").GetComponent<Text>();
        UpdateKnowledge(m_currentMonster.getKnowledge());

        relationshipText = GameObject.Find("RelationshipText").GetComponent<Text>();
        UpdateRelationship(m_currentMonster.getRelationship());
    }

    void SetMonster (Monster currentMonster)
    {
        m_currentMonster = currentMonster;

        // Monster Events Subscription
        m_currentMonster.onUpdateHunger += UpdateHunger;
        m_currentMonster.onUpdateMood += UpdateMood;
        m_currentMonster.onUpdateKnowledge += UpdateKnowledge;
        m_currentMonster.onUpdateRelationship += UpdateRelationship;
    }

    #region Update Methods

    void UpdateMood(short mood)
    {
        moodText.text = "Mood : " + mood.ToString();
    }
    
    void UpdateHunger(short hunger)
    {
        hungerText.text = "Hunger : " + hunger.ToString();
    }

    void UpdateKnowledge(short knowledge)
    {
        knowledgeText.text = "Knowledge : " + knowledge.ToString();
    }

    void UpdateRelationship(short relationship)
    {
        relationshipText.text = "Relationship : " + relationship.ToString();
    }

    void UpdateFood(short food)
    {
        foodText.text = "Food : " + food.ToString();
    }
    
    #endregion
}