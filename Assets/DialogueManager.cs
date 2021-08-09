using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
[System.Serializable]
public class Dialogue
{
    public string nameChara;
    public string dialogueChara;
    public Sprite portraitChara;
}

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public TextMeshProUGUI nombreText;
    public TextMeshProUGUI dialogoText;
    public Image retrato;
    public List<Dialogue> dialogos;
    
    public int index;

    private void Awake()
    {
        instance = this;
    }    
    void Start()
    {
        index = 0;
        ShowDialogo(dialogos[index]);
    }
    public void ShowDialogo(Dialogue dialogue)
    {
        nombreText.text = dialogue.nameChara;
        dialogoText.text = dialogue.dialogueChara;
        retrato.sprite = dialogue.portraitChara;
    }
    public void NextDialogue()
    {
        index++;
        if(index >= dialogos.Count)
        {
            index = 0;
            ShowDialogo(dialogos[index]);
            //fin de la conversa.
        }
        else
        {
            ShowDialogo(dialogos[index]);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("indexValue", index);
    }
    public void Load()
    {
        index = PlayerPrefs.GetInt("indexValue");
        ShowDialogo(dialogos[index]);
    }
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
        index = 0;
        ShowDialogo(dialogos[index]);
    }
   
}
