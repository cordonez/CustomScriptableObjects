namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(SOEvent_Layermask), true)]
	public class SOEvent_LayermaskEditor : CustomScriptableEventEditor<LayerMask>
	{
		protected override void DrawInvokeValue(ref LayerMask _invokeValue)
		{
			_invokeValue = EditorGUILayout.LayerField(_invokeValue);
		}
	}
}