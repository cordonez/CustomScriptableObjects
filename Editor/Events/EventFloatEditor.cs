namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventFloat), true)]
	public class EventFloatEditor : CustomScriptableEventEditor<float>
	{
		protected override void DrawInvokeValue(ref float _invokeValue)
		{
			_invokeValue = EditorGUILayout.FloatField(_invokeValue);
		}
	}
}