namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(SOEvent_float), true)]
	public class SOEvent_floatEditor : CustomScriptableEventEditor<float>
	{
		protected override void DrawInvokeValue(ref float _invokeValue)
		{
			_invokeValue = EditorGUILayout.FloatField(_invokeValue);
		}
	}
}