namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Bool")]
	[Serializable]
	public class EventBool : BaseEvent<bool> { }
}