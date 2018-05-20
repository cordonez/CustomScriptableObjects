using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_double), true)]
	public class SOEvent_doubleEditor : CustomScriptableEventEditor<double>
	{
		protected override void DrawInvokeValue(ref double _invokeValue)
		{
			_invokeValue = EditorGUILayout.DoubleField(_invokeValue);
		}
	}
}