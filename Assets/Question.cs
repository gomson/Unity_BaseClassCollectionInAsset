using System;
using UnityEditor;
using UnityEngine;

[Serializable]
public class Question : ScriptableObject
{
	[Range(0, 100)]
	[SerializeField] protected int m_IntField;

	//public void OnEnable () { hideFlags = HideFlags.HideAndDontSave; }
}