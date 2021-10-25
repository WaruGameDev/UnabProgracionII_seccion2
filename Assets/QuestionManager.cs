using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<QuestionBase> questions;
    public TextMeshProUGUI question;
    public List<TextMeshProUGUI> answers;
    public List<Respuesta> answersButton;
    public void LoaderQuestion()
    {
        question.text = questions[0].pregunta;
        for (int i = 0; i < answers.Count; i++)
        {
            answers[i].text = questions[0].respuestas[i];
            
        }
        answersButton[questions[0].respuestaCorrecta].isCorrect = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        LoaderQuestion();
    }

    
}
