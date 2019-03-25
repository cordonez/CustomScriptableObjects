namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventString), true)]
	public class EventStringEditor : CustomScriptableEventEditor<string>
	{
		protected override void DrawInvokeValue(ref string _invokeValue)
		{
			_invokeValue = EditorGUILayout.TextField(_invokeValue);
		}
	}
}