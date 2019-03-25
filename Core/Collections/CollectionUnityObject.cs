namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "UnityObject")]
	[Serializable]
	public class CollectionUnityObject : BaseCollection<UnityEngine.Object> { }
}