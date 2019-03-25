namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Decimal")]
	[Serializable]
	public class EventDecimal : BaseEvent<decimal> { }
}