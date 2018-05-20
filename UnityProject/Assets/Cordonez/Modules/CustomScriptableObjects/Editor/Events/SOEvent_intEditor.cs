using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_int), true)]
	public class SOEvent_intEditor : CustomScriptableEventEditor<int>
	{
		protected override void DrawInvokeValue(ref int _invokeValue)
		{
			_invokeValue = EditorGUILayout.IntField(_invokeValue);
		}
	}
}