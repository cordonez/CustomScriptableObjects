namespace Cordonez.Modules.CustomScriptableObjects.Editor.Variables
{
	using System;
	using System.Reflection;
	using Core;
	using UnityEditor;

	[CustomEditor(typeof(CustomScriptableObject<>), true)]
	public class CustomScriptableObjectEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			EditorGUILayout.Separator();
			FieldInfo field = target.GetType().GetField("m_onValueUpdated", BindingFlags.NonPublic | BindingFlags.Instance);
			if (field == null)
			{
				return;
			}

			object actions = field.GetValue(target);
			if (actions != null)
			{
				object delegateObjects = actions.GetType().GetMethod("GetInvocationList").Invoke(actions, null);
				CustomScriptableEventsEditorUtils.DrawInvocationList(delegateObjects as Delegate[]);
			}
		}
	}
}