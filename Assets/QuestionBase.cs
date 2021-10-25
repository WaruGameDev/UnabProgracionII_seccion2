using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Question", menuName = "Quiz/Question", order = 0)]
public class QuestionBase : ScriptableObject
{
    public string pregunta;
    public int respuestaCorrecta;
    public string[] respuestas = new string[3];



}
