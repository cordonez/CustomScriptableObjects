namespace Cordonez.Modules.CustomScriptableObjects.Core.Events
{
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "SOEvent_Gameobject")]
	public class SOEvent_Gameobject : CustomScriptableEvent<GameObject> { }
}