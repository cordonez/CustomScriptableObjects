using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_ushort), true)]
	public class SOEvent_ushortEditor : CustomScriptableEventEditor<ushort>
	{
		protected override void DrawInvokeValue(ref ushort _invokeValue)
		{
			_invokeValue = (ushort)EditorGUILayout.IntField(_invokeValue);
		}
	}
}