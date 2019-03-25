namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "UInt")]
	[Serializable]
	public class CollectionUInt : BaseCollection<uint> { }
}