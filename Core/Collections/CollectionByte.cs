namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Byte")]
	[Serializable]
	public class CollectionByte : BaseCollection<byte> { }
}