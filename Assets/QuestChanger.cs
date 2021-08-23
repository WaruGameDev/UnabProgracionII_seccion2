using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestChanger : MonoBehaviour
{
    public List<Quest> questsToChange;
    
    public void SetQuest()
    {
        foreach(Quest q in questsToChange)
        {
            QuestManager.instance.SetQuestState(q.nombreQuest, q.questState);
        }
       
    }
   
}
