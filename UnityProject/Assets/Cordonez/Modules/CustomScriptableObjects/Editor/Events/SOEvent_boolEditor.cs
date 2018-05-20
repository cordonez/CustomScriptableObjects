using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_bool), true)]
	public class SOEvent_boolEditor : CustomScriptableEventEditor<bool>
	{
		protected override void DrawInvokeValue(ref bool _invokeValue)
		{
			_invokeValue = EditorGUILayout.Toggle(_invokeValue);
		}
	}
}