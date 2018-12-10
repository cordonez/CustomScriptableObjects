namespace Cordonez.Modules.CustomScriptableObjects.Editor
{
	using System;
	using System.Reflection;
	using Core;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(CustomScriptableEvent), true)]
	public class CustomScriptableEventDrawer : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			CustomScriptableEvent myTarget = (CustomScriptableEvent) target;
			if (GUILayout.Button("Invoke"))
			{
				myTarget.Invoke();
			}

			FieldInfo field = typeof(CustomScriptableEvent).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
			if (field == null)
			{
				return;
			}

			object actions = field.GetValue(myTarget);
			if (actions != null)
			{
				CustomScriptableEventDrawerUtils.DrawInvocationList(((Action) actions).GetInvocationList());
			}
		}
	}

	[CustomEditor(typeof(CustomScriptableEvent), true)]
	public abstract class CustomScriptableEventEditor<T1> : Editor
	{
		private T1 m_editorInvokeValue;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			CustomScriptableEvent<T1> myTarget = (CustomScriptableEvent<T1>) target;
			EditorGUILayout.BeginHorizontal();
			{
				EditorGUILayout.LabelField("Invoke value:");
				DrawInvokeValue(ref m_editorInvokeValue);
			}
			EditorGUILayout.EndHorizontal();
			if (GUILayout.Button("Invoke"))
			{
				myTarget.Invoke(m_editorInvokeValue);
			}

			FieldInfo field = typeof(CustomScriptableEvent<T1>).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
			if (field == null)
			{
				return;
			}

			object actions = field.GetValue(myTarget);
			if (actions != null)
			{
				CustomScriptableEventDrawerUtils.DrawInvocationList(((Action<T1>) actions).GetInvocationList());
			}
		}

		protected abstract void DrawInvokeValue(ref T1 _invokeValue);
	}

	[CustomEditor(typeof(CustomScriptableEvent), true)]
	public abstract class CustomScriptableEventEditor<T1, T2> : Editor
	{
		private T1 m_firstInvokeValue;
		private T2 m_secondInvokeValue;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			CustomScriptableEvent<T1, T2> myTarget = (CustomScriptableEvent<T1, T2>) target;
			EditorGUILayout.BeginHorizontal();
			{
				EditorGUILayout.LabelField("Invoke values:");
				DrawInvokeValue(ref m_firstInvokeValue, ref m_secondInvokeValue);
			}
			EditorGUILayout.EndHorizontal();
			if (GUILayout.Button("Invoke"))
			{
				myTarget.Invoke(m_firstInvokeValue, m_secondInvokeValue);
			}

			FieldInfo field = typeof(CustomScriptableEvent<T1, T2>).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
			if (field == null)
			{
				return;
			}

			object actions = field.GetValue(myTarget);
			if (actions != null)
			{
				CustomScriptableEventDrawerUtils.DrawInvocationList(((Action<T1, T2>) actions).GetInvocationList());
			}
		}

		protected abstract void DrawInvokeValue(ref T1 _firstInvokeValue, ref T2 _secondInvokeValue);
	}

	[CustomEditor(typeof(CustomScriptableEvent), true)]
	public abstract class CustomScriptableEventEditor<T1, T2, T3> : Editor
	{
		private T1 m_firstInvokeValue;
		private T2 m_secondInvokeValue;
		private T3 m_thirdInvokeValue;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			CustomScriptableEvent<T1, T2, T3> myTarget = (CustomScriptableEvent<T1, T2, T3>) target;
			EditorGUILayout.BeginHorizontal();
			{
				EditorGUILayout.LabelField("Invoke values:");
				DrawInvokeValue(ref m_firstInvokeValue, ref m_secondInvokeValue, ref m_thirdInvokeValue);
			}
			EditorGUILayout.EndHorizontal();
			if (GUILayout.Button("Invoke"))
			{
				myTarget.Invoke(m_firstInvokeValue, m_secondInvokeValue, m_thirdInvokeValue);
			}

			FieldInfo field = typeof(CustomScriptableEvent<T1, T2, T3>).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
			if (field == null)
			{
				return;
			}

			object actions = field.GetValue(myTarget);
			if (actions != null)
			{
				CustomScriptableEventDrawerUtils.DrawInvocationList(((Action<T1, T2, T3>) actions).GetInvocationList());
			}
		}

		protected abstract void DrawInvokeValue(ref T1 _firstInvokeValue, ref T2 _secondInvokeValue, ref T3 _thirdInvokeValue);
	}
}