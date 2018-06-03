using Cordonez.Modules.CustomScriptableObjects.Core.Variables;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Variables
{
	[CustomEditor(typeof(SO_Scene), true)]
	public class SO_SceneEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			SO_Scene picker = target as SO_Scene;
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

			serializedObject.ApplyModifiedProperties();
		}
	}
}