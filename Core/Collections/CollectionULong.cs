namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "ULong")]
	[Serializable]
	public class CollectionULong : BaseCollection<ulong> { }
}