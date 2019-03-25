namespace CustomScriptableObjects.Editor.Variables
{
	using Core.Variables;
	using UnityEditor;

	[CustomEditor(typeof(VarScene), true)]
	public class VarSceneEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			VarScene picker = target as VarScene;
			if (picker != null)
			{
				SceneAsset oldScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(picker.Value);
				serializedObject.Update();
				EditorGUI.BeginChangeCheck();
				SceneAsset newScene = EditorGUILayout.ObjectField("Scene", oldScene, typeof(SceneAsset), false) as SceneAsset;
				if (EditorGUI.EndChangeCheck())
				{
					string newPath = AssetDatabase.GetAssetPath(newScene);
					SerializedProperty scenePathProperty = serializedObject.FindProperty("m_value");
					scenePathProperty.stringValue = newPath;
				}
			}

			serializedObject.ApplyModifiedProperties();
		}
	}
}