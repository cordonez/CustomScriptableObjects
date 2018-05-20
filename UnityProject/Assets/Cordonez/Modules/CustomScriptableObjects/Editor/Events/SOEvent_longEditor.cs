using Cordonez.Modules.CustomScriptableObjects.Core.Events;
using UnityEditor;

namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	[CustomEditor(typeof(SOEvent_long), true)]
	public class SOEvent_longEditor : CustomScriptableEventEditor<long>
	{
		protected override void DrawInvokeValue(ref long _invokeValue)
		{
			_invokeValue = EditorGUILayout.LongField(_invokeValue);
		}
	}
}