namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "GameObject")]
	[Serializable]
	public class EventGameObject : BaseEvent<GameObject> { }
}