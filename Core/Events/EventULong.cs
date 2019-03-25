namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "ULong")]
	[Serializable]
	public class EventULong : BaseEvent<ulong> { }
}