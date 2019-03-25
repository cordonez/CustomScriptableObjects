namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarInt")]
	[Serializable]
	public class CollectionVarInt : BaseCollection<VarInt> { }
}