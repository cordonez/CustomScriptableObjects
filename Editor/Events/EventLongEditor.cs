namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventLong), true)]
	public class EventLongEditor : CustomScriptableEventEditor<long>
	{
		protected override void DrawInvokeValue(ref long _invokeValue)
		{
			_invokeValue = EditorGUILayout.LongField(_invokeValue);
		}
	}
}