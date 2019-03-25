namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(EventVector2), true)]
	public class EventVector2Editor : CustomScriptableEventEditor<Vector2>
	{
		protected override void DrawInvokeValue(ref Vector2 _invokeValue)
		{
			_invokeValue = EditorGUILayout.Vector2Field("", _invokeValue);
		}
	}
}