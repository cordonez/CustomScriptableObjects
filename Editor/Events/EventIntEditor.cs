namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventInt), true)]
	public class EventIntEditor : CustomScriptableEventEditor<int>
	{
		protected override void DrawInvokeValue(ref int _invokeValue)
		{
			_invokeValue = EditorGUILayout.IntField(_invokeValue);
		}
	}
}