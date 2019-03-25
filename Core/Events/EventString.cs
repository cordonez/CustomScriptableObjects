namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "String")]
	[Serializable]
	public class EventString : BaseEvent<string> { }
}