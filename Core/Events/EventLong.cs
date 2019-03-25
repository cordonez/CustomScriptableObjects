namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Long")]
	[Serializable]
	public class EventLong : BaseEvent<long> { }
}