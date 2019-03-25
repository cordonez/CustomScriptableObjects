namespace CustomScriptableObjects.Core.Events
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.EVENTS + "UnityObject")]
	[Serializable]
	public class EventUnityObject : BaseEvent<UnityEngine.Object> { }
}