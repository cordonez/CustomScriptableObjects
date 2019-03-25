namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "UShort")]
	[Serializable]
	public class EventUShort : BaseEvent<ushort> { }
}