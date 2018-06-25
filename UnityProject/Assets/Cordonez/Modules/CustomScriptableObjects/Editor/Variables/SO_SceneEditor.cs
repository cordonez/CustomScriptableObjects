namespace Cordonez.Modules.CustomScriptableObjects.Editor.Variables
{
	using Core.Variables;
	using UnityEditor;

	[CustomEditor(typeof(SO_Scene), true)]
	public class SO_SceneEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			SO_Scene picker = target as SO_Scene;
			if (picker != null)
			{
				SceneAsset oldScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(picker.Value);
				serializedObject.Update();
				EditorGUI.BeginChangeCheck();
				SceneAsset newScene = EditorGUILayout.ObjectField("scene", oldScene, typeof(SceneAsset), false) as SceneAsset;
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