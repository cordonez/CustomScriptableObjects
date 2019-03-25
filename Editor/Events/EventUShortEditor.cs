namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventUShort), true)]
	public class EventUShortEditor : CustomScriptableEventEditor<ushort>
	{
		protected override void DrawInvokeValue(ref ushort _invokeValue)
		{
			_invokeValue = (ushort) EditorGUILayout.IntField(_invokeValue);
		}
	}
}