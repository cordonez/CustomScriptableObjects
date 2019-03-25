namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Float")]
	[Serializable]
	public class EventFloat : BaseEvent<float> { }
}