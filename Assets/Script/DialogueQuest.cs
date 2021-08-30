using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueQuest : MonoBehaviour
{
    public CanvasGroup panelText;
    public TextMeshProUGUI dialogueText;
    public List<string> dialogues;
    
    public void ShowDialogue()
    {
        Quest quest = GetComponent<QuestChanger>().questsToChange[0];
        dialogueText.text = dialogues[(int)QuestManager.instance.GetQuestState(quest.nombreQuest)];
        panelText.alpha = 1;
    }

}
