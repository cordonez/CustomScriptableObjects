namespace CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(EventGameObject), true)]
	public class EventGameObjectEditor : CustomScriptableEventEditor<GameObject>
	{
		protected override void DrawInvokeValue(ref GameObject _invokeValue)
		{
			_invokeValue = (GameObject) EditorGUILayout.ObjectField(_invokeValue, typeof(GameObject), true);
		}
	}
}