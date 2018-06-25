namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_string), true)]
	public class SOEvent_stringEditor : CustomScriptableEventEditor<string>
	{
		protected override void DrawInvokeValue(ref string _invokeValue)
		{
			_invokeValue = EditorGUILayout.TextField(_invokeValue);
		}
	}
}