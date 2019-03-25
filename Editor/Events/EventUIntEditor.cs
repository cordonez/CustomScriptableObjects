namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventUInt), true)]
	public class EventUIntEditor : CustomScriptableEventEditor<uint>
	{
		protected override void DrawInvokeValue(ref uint _invokeValue)
		{
			_invokeValue = (uint) EditorGUILayout.IntField((int) _invokeValue);
		}
	}
}