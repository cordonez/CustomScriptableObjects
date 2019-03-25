namespace CustomScriptableObjects.Editor
{
	using System;
	using System.Reflection;
	using Core;
	using UnityEditor;

	[CustomEditor(typeof(BaseVariable<>), true)]
	public class CustomScriptableObjectDrawer : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			DrawOnValueUpdated();
			DrawInstanceValues();
		}

		private void DrawInstanceValues()
		{
			EditorGUILayout.Separator();
			EditorGUILayout.LabelField("Instance values: ", EditorStyles.boldLabel);
			FieldInfo fieldInfo = target.GetType().GetField("m_instanceValues", BindingFlags.NonPublic | BindingFlags.Instance);
			if (fieldInfo == null)
			{
				return;
			}

			object instanceValues = fieldInfo.GetValue(target);
			if (instanceValues == null)
			{
				return;
			}

			FieldInfo keyFields = instanceValues.GetType().GetField("keySlots", BindingFlags.NonPublic | BindingFlags.Instance);
			FieldInfo valueFields = instanceValues.GetType().GetField("valueSlots", BindingFlags.NonPublic | BindingFlags.Instance);
			if (keyFields == null || valueFields == null)
			{
				return;
			}

			object keyObjects = keyFields.GetValue(instanceValues);
			object valueObjects = valueFields.GetValue(instanceValues);
			Array keyArray = keyObjects as Array;
			Array valueArray = valueObjects as Array;
			for (int i = 0; i < keyArray.Length; i++)
			{
				object key = keyArray.GetValue(i);
				object value = valueArray.GetValue(i);
				EditorGUILayout.TextField(key + ": " + value);
			}
		}

		private void DrawOnValueUpdated()
		{
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
				CustomScriptableEventDrawerUtils.DrawInvocationList(delegateObjects as Delegate[]);
			}
		}
	}
}