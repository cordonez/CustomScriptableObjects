namespace CustomScriptableObjects.Editor.Events
{
	using System.Linq;
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventChar), true)]
	public class EventCharEditor : CustomScriptableEventEditor<char>
	{
		protected override void DrawInvokeValue(ref char _invokeValue)
		{
			string s = _invokeValue.ToString();
			_invokeValue = EditorGUILayout.TextField(s).ToCharArray().FirstOrDefault();
		}
	}
}