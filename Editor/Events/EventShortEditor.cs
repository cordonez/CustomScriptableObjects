namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventShort), true)]
	public class EventShortEditor : CustomScriptableEventEditor<short>
	{
		protected override void DrawInvokeValue(ref short _invokeValue)
		{
			_invokeValue = (short) EditorGUILayout.IntField(_invokeValue);
		}
	}
}