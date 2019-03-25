namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "SByte")]
	[Serializable]
	public class EventSByte : BaseEvent<sbyte> { }
}