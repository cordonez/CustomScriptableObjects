namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "LayerMask")]
	[Serializable]
	public class EventLayerMask : BaseEvent<LayerMask> { }
}