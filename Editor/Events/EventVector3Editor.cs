namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(EventVector3), true)]
	public class EventVector3Editor : CustomScriptableEventEditor<Vector3>
	{
		protected override void DrawInvokeValue(ref Vector3 _invokeValue)
		{
			_invokeValue = EditorGUILayout.Vector3Field("", _invokeValue);
		}
	}
}