namespace Cordonez.Modules.CustomScriptableObjects.Editor.Events
{
	using Core.Events;
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(SOEvent_Gameobject), true)]
	public class SOEvent_GameobjectEditor : CustomScriptableEventEditor<GameObject>
	{
		protected override void DrawInvokeValue(ref GameObject _invokeValue)
		{
			_invokeValue = (GameObject) EditorGUILayout.ObjectField(_invokeValue, typeof(GameObject), true);
		}
	}
}