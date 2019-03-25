namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(EventVector4), true)]
	public class EventVector4Editor : CustomScriptableEventEditor<Vector4>
	{
		protected override void DrawInvokeValue(ref Vector4 _invokeValue)
		{
			_invokeValue = EditorGUILayout.Vector4Field("", _invokeValue);
		}
	}
}