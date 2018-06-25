namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_int), true)]
	public class SOEvent_intEditor : CustomScriptableEventEditor<int>
	{
		protected override void DrawInvokeValue(ref int _invokeValue)
		{
			_invokeValue = EditorGUILayout.IntField(_invokeValue);
		}
	}
}