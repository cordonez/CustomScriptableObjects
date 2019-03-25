namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarUInt")]
	[Serializable]
	public class CollectionVarUInt : BaseCollection<VarUInt> { }
}