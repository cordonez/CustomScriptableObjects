namespace CustomScriptableObjects.Editor
{
	using System;
	using UnityEditor;
	using UnityEngine;

	public static class CustomScriptableEventDrawerUtils
	{
		/// <summary>
		///     Shows on inspector a list of the delegates as a foldout that can be expandable to view more
		///     details about the call.
		/// </summary>
		/// <param name="_invocationList">Delegates that will be shown on the inspector</param>
		public static void DrawInvocationList(Delegate[] _invocationList)
		{
			if (_invocationList == null || _invocationList.Length <= 0)
			{
				return;
			}

			EditorGUILayout.LabelField("Callbacks: ", EditorStyles.boldLabel);
			foreach (Delegate callback in _invocationList)
			{
				if (callback.Method.DeclaringType != null)
				{
					if (callback.Target == null)
					{
						EditorGUILayout.TextField(callback.Method.DeclaringType.Name + " --> " + callback.Method.Name);
					}
					else
					{
						if (GUILayout.Button(callback.Method.DeclaringType.Name + " --> " + callback.Method.Name))
						{
							Selection.activeGameObject = (callback.Target as MonoBehaviour).gameObject;
						}
					}
				}
				else
				{
					EditorGUILayout.LabelField("Null method declaring type.");
				}
			}
		}
	}
}