using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuizData : ScriptableObject
{
	public string quizText;
	public List<Question> questions = new List<Question>();
}