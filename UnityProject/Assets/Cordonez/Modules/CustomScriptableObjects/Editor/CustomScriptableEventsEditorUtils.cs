using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Editor
{
	public static class CustomScriptableEventsEditorUtils
	{
		/// <summary>
		/// Shows on inspector a list of the delegates as a foldout that can be expandable to view more
		/// details about the call.
		/// </summary>
		/// <param name="_invocationList">Delegates that will be shown on the inspector</param>
		/// <param name="_invocationListVisibility">Contains which elements of the inspector show the detailed
		/// description.</param>
		public static void DrawInvocationList(Delegate[] _invocationList, ref bool[] _invocationListVisibility)
		{
			if (_invocationList == null || _invocationList.Length <= 0)
			{
				return;
			}

			if (_invocationListVisibility == null || _invocationListVisibility.Length != _invocationList.Length)
			{
				_invocationListVisibility = new bool[_invocationList.Length];
			}

			EditorGUILayout.LabelField("Callbacks: ", EditorStyles.boldLabel);
			for (int i = 0; i < _invocationList.Length; i++)
			{
				if (_invocationList[i].Method.DeclaringType != null)
				{
					_invocationListVisibility[i] = EditorGUILayout.Foldout(_invocationListVisibility[i], _invocationList[i].Method.DeclaringType.Name + " --> " + _invocationList[i].Method.Name, true, EditorStyles.helpBox);

					if (_invocationListVisibility[i])
					{
						DrawMethodInformation(_invocationList[i].Method);
					}
				}
				else
				{
					EditorGUILayout.LabelField("Null method declaring type.");
				}
			}
		}

		private static void DrawMethodInformation(MethodInfo _method)
		{
			DrawProperty("Assembly:", _method.Module.Name);
			DrawProperty("Class:", _method.DeclaringType.Name);
			DrawProperty("Full name:", _method.DeclaringType.FullName);
			DrawProperty("Attributes:", _method.Attributes.ToString());
			DrawProperty("Calling convention:", _method.CallingConvention.ToString());
			DrawProperty("Member Type:", _method.MemberType.ToString());
		}

		private static void DrawProperty(string _id, string _value)
		{
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.LabelField(_id, GUILayout.Width(120));
			EditorGUILayout.TextField(_value);
			EditorGUILayout.EndHorizontal();
		}
	}
}