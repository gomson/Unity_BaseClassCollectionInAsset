using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Manager))]
public class ManangerEditor : Editor
{
	private void OnEnable ()
	{
		Manager target = (Manager) base.target;

		if ( target.quizData == null )
		{
			string projectRelativeFilePath = "Assets/" + typeof(QuizData).Name + ".asset";

			//Try to load existing asset.
			QuizData asset = (QuizData) AssetDatabase.LoadAssetAtPath(projectRelativeFilePath, typeof(QuizData));

			//If none exists, create a new one.
			if ( asset == null )
			{
				asset = ScriptableObject.CreateInstance<QuizData>();
				AssetDatabase.CreateAsset(asset, projectRelativeFilePath);
			}

			target.quizData = asset;
		}
	}
}