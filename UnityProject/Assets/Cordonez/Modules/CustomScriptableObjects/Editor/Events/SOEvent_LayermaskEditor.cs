using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;
using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_Layermask), true)]
	public class SOEvent_LayermaskEditor : CustomScriptableEventEditor<LayerMask>
	{
		protected override void DrawInvokeValue(ref LayerMask _invokeValue)
		{
			_invokeValue = EditorGUILayout.LayerField(_invokeValue);
		}
	}
}