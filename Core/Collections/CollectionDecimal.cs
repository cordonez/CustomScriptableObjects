namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Decimal")]
	[Serializable]
	public class CollectionDecimal : BaseCollection<decimal> { }
}