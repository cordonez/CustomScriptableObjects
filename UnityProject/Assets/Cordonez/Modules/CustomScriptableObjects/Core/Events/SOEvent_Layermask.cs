namespace Cordonez.Modules.CustomScriptableObjects.Core.Events
{
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "SOEvent_Layermask")]
	public class SOEvent_Layermask : CustomScriptableEvent<LayerMask> { }
}