namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_long), true)]
	public class SOEvent_longEditor : CustomScriptableEventEditor<long>
	{
		protected override void DrawInvokeValue(ref long _invokeValue)
		{
			_invokeValue = EditorGUILayout.LongField(_invokeValue);
		}
	}
}