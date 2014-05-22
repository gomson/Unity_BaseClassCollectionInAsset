using UnityEditor;

[CustomEditor(typeof(Question))]
public class QuestionEditor : Editor
{
	public override void OnInspectorGUI ()
	{
		DrawPropertiesExcluding(serializedObject, "m_Script");

		serializedObject.ApplyModifiedProperties();
	}
}