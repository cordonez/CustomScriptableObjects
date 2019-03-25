namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventDouble), true)]
	public class EventDoubleEditor : CustomScriptableEventEditor<double>
	{
		protected override void DrawInvokeValue(ref double _invokeValue)
		{
			_invokeValue = EditorGUILayout.DoubleField(_invokeValue);
		}
	}
}