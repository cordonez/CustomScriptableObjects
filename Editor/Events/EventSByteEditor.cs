namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventSByte), true)]
	public class EventSByteEditor : CustomScriptableEventEditor<sbyte>
	{
		protected override void DrawInvokeValue(ref sbyte _invokeValue)
		{
			_invokeValue = (sbyte) EditorGUILayout.IntField(_invokeValue);
		}
	}
}