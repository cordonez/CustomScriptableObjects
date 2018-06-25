namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_bool), true)]
	public class SOEvent_boolEditor : CustomScriptableEventEditor<bool>
	{
		protected override void DrawInvokeValue(ref bool _invokeValue)
		{
			_invokeValue = EditorGUILayout.Toggle(_invokeValue);
		}
	}
}