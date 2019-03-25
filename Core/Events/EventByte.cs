namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Byte")]
	[Serializable]
	public class EventByte : BaseEvent<byte> { }
}