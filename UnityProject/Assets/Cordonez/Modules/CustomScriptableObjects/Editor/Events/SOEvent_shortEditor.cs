namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_short), true)]
	public class SOEvent_shortEditor : CustomScriptableEventEditor<short>
	{
		protected override void DrawInvokeValue(ref short _invokeValue)
		{
			_invokeValue = (short) EditorGUILayout.IntField(_invokeValue);
		}
	}
}