namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(EventLayerMask), true)]
	public class EventLayerMaskEditor : CustomScriptableEventEditor<LayerMask>
	{
		protected override void DrawInvokeValue(ref LayerMask _invokeValue)
		{
			_invokeValue = EditorGUILayout.LayerField(_invokeValue);
		}
	}
}