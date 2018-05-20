using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_string), true)]
	public class SOEvent_stringEditor : CustomScriptableEventEditor<string>
	{
		protected override void DrawInvokeValue(ref string _invokeValue)
		{
			_invokeValue = EditorGUILayout.TextField(_invokeValue);
		}
	}
}