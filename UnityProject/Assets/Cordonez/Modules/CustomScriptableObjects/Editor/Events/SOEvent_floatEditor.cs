using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_float), true)]
	public class SOEvent_floatEditor : CustomScriptableEventEditor<float>
	{
		protected override void DrawInvokeValue(ref float _invokeValue)
		{
			_invokeValue = EditorGUILayout.FloatField(_invokeValue);
		}
	}
}