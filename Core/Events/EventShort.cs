namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Short")]
	[Serializable]
	public class EventShort : BaseEvent<short> { }
}