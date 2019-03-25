namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Vector3")]
	[Serializable]
	public class EventVector3 : BaseEvent<Vector3> { }
}