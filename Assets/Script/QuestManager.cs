using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Quest
{
    public string nombreQuest;
    public enum QUEST_STATE
    {
        UNNASSIGNED = 0,
        ASSIGNED = 1,
        COMPLETE = 2
    }
    public QUEST_STATE questState;
}

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests;
    public static QuestManager instance;
    public Transform panelQuest;
    public GameObject questInfo;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        foreach (Quest q in quests)
        {
            GameObject questInfoPanel = Instantiate(questInfo, panelQuest);
            questInfoPanel.GetComponent<PanelInfoQuest>().questInfo = q.nombreQuest;
        }
    }

    private void Awake()
    {
        instance = this;
    }
    // setear el estado una quest
    public void SetQuestState(string nameQuest, Quest.QUEST_STATE newQuestState)
    {
        foreach(Quest q in quests)
        {
            if(q.nombreQuest == nameQuest)
            {
                q.questState = newQuestState;
            }
        }
    }
    // obtener el estado de una quest
    public Quest.QUEST_STATE GetQuestState(string nameQuest)
    {
        Quest.QUEST_STATE qState = Quest.QUEST_STATE.UNNASSIGNED;
        foreach(Quest q in quests)
        {
            if(q.nombreQuest == nameQuest)
            {
                qState = q.questState;
            }
        }

        return qState;
    }

    public void ResetQuest()
    {
        foreach(Quest q in quests)
        {
            q.questState = Quest.QUEST_STATE.UNNASSIGNED;
        }
    }

    //private void Update()
    //{
    //    if(Input.GetButtonDown("Jump"))
    //    {
    //        SetQuestState("Esmeralda", Quest.QUEST_STATE.COMPLETE);
    //        print(GetQuestState("Ruby"));
    //    }
    //}

}
