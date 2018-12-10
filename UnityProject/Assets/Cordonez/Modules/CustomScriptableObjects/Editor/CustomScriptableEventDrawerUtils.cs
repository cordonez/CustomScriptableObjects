namespace Cordonez.Modules.CustomScriptableObjects.Editor
{
	using System;
	using UnityEditor;

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
			for (int i = 0; i < _invocationList.Length; i++)
			{
				if (_invocationList[i].Method.DeclaringType != null)
				{
					EditorGUILayout.TextField(_invocationList[i].Method.DeclaringType.Name + " --> " + _invocationList[i].Method.Name);
				}
				else
				{
					EditorGUILayout.LabelField("Null method declaring type.");
				}
			}
		}
	}
}