namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventBool), true)]
	public class EventBoolEditor : CustomScriptableEventEditor<bool>
	{
		protected override void DrawInvokeValue(ref bool _invokeValue)
		{
			_invokeValue = EditorGUILayout.Toggle(_invokeValue);
		}
	}
}