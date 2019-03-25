namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "Vector4")]
	[Serializable]
	public class EventVector4 : BaseEvent<Vector4> { }
}