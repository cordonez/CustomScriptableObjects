namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Int")]
	[Serializable]
	public class EventInt : BaseEvent<int> { }
}