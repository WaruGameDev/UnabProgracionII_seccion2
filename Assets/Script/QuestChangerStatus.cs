using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestChangerStatus : MonoBehaviour
{
    public string nameQuest;
    public Quest.QUEST_STATE requireState;
    public Quest.QUEST_STATE newQueststate;
    public UnityEvent onQuestStateChange;
    
    public void ChangeQuestState()
    {
        if(QuestManager.instance.GetQuestState(nameQuest) == requireState)
        {
            QuestManager.instance.SetQuestState(nameQuest, newQueststate);
            onQuestStateChange?.Invoke();
        }
    }
}
