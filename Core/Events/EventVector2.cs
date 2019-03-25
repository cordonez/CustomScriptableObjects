namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Vector2")]
	[Serializable]
	public class EventVector2 : BaseEvent<Vector2> { }
}