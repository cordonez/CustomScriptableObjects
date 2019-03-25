namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "UInt")]
	[Serializable]
	public class EventUInt : BaseEvent<uint> { }
}