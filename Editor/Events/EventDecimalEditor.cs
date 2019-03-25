namespace CustomScriptableObjects.Editor.Events
{
	using System.Globalization;
	using Core.Events;
	using UnityEditor;

	[CustomEditor(typeof(EventDecimal), true)]
	public class EventDecimalEditor : CustomScriptableEventEditor<decimal>
	{
		protected override void DrawInvokeValue(ref decimal _invokeValue)
		{
			string s = _invokeValue.ToString(CultureInfo.InvariantCulture);
			_invokeValue = System.Convert.ToDecimal(EditorGUILayout.TextField(s));
		}
	}
}