namespace CustomScriptableObjects.Editor
{
	using System;
	using System.Reflection;
	using Core;
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(Core.Events.BaseEvent), true)]
	public class CustomScriptableEventDrawer : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			Core.Events.BaseEvent myTarget = (Core.Events.BaseEvent) target;
			if (GUILayout.Button("Invoke"))
			{
				myTarget.Invoke();
			}

			FieldInfo field = typeof(Core.Events.BaseEvent).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
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

	[CustomEditor(typeof(Core.Events.BaseEvent), true)]
	public abstract class CustomScriptableEventEditor<T1> : Editor
	{
		private T1 m_editorInvokeValue;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			BaseEvent<T1> myTarget = (BaseEvent<T1>) target;
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

			FieldInfo field = typeof(BaseEvent<T1>).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
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

	[CustomEditor(typeof(Core.Events.BaseEvent), true)]
	public abstract class CustomScriptableEventEditor<T1, T2> : Editor
	{
		private T1 m_firstInvokeValue;
		private T2 m_secondInvokeValue;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			BaseEvent<T1, T2> myTarget = (BaseEvent<T1, T2>) target;
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

			FieldInfo field = typeof(BaseEvent<T1, T2>).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
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

	[CustomEditor(typeof(Core.Events.BaseEvent), true)]
	public abstract class CustomScriptableEventEditor<T1, T2, T3> : Editor
	{
		private T1 m_firstInvokeValue;
		private T2 m_secondInvokeValue;
		private T3 m_thirdInvokeValue;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			BaseEvent<T1, T2, T3> myTarget = (BaseEvent<T1, T2, T3>) target;
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

			FieldInfo field = typeof(BaseEvent<T1, T2, T3>).GetField("m_actions", BindingFlags.NonPublic | BindingFlags.Instance);
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