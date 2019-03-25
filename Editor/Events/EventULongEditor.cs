namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventULong), true)]
	public class EventULongEditor : CustomScriptableEventEditor<ulong>
	{
		protected override void DrawInvokeValue(ref ulong _invokeValue)
		{
			_invokeValue = (ulong) EditorGUILayout.DoubleField(_invokeValue);
		}
	}
}