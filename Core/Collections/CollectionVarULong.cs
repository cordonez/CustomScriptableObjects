namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarULong")]
	[Serializable]
	public class CollectionVarULong : BaseCollection<VarULong> { }
}