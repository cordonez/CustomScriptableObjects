namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventByte), true)]
	public class EventByteEditor : CustomScriptableEventEditor<byte>
	{
		protected override void DrawInvokeValue(ref byte _invokeValue)
		{
			_invokeValue = (byte) EditorGUILayout.IntField(_invokeValue);
		}
	}
}