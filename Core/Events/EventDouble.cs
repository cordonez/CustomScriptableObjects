namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Double")]
	[Serializable]
	public class EventDouble : BaseEvent<double> { }
}