using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelInfoQuest : MonoBehaviour
{
    public TextMeshProUGUI textoInfoQuest;
    public string questInfo;

    private void Update()
    {
        switch(QuestManager.instance.GetQuestState(questInfo))
        {
            case Quest.QUEST_STATE.UNNASSIGNED:
                textoInfoQuest.text = "La quest " + questInfo + " esta no asignada";
                break;
            case Quest.QUEST_STATE.ASSIGNED:
                textoInfoQuest.text = "La quest " + questInfo + " esta asignada";
                break;
            case Quest.QUEST_STATE.COMPLETE:
                textoInfoQuest.text = "La quest " + questInfo + " esta completa";
                break;
        }
    }

}
