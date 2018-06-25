namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_ushort), true)]
	public class SOEvent_ushortEditor : CustomScriptableEventEditor<ushort>
	{
		protected override void DrawInvokeValue(ref ushort _invokeValue)
		{
			_invokeValue = (ushort) EditorGUILayout.IntField(_invokeValue);
		}
	}
}