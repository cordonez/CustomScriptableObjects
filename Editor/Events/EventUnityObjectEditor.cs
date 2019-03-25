namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(EventUnityObject), true)]
	public class EventUnityObjectEditor : CustomScriptableEventEditor<Object>
	{
		protected override void DrawInvokeValue(ref Object _invokeValue)
		{
			_invokeValue = (GameObject) EditorGUILayout.ObjectField(_invokeValue, typeof(Object), true);
		}
	}
}