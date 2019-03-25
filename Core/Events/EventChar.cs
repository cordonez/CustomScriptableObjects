namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Char")]
	[Serializable]
	public class EventChar : BaseEvent<char> { }
}