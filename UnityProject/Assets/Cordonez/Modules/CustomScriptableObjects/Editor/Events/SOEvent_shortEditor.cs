using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_short), true)]
	public class SOEvent_shortEditor : CustomScriptableEventEditor<short>
	{
		protected override void DrawInvokeValue(ref short _invokeValue)
		{
			_invokeValue = (short)EditorGUILayout.IntField(_invokeValue);
		}
	}
}