namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Long")]
	[Serializable]
	public class CollectionLong : BaseCollection<long> { }
}