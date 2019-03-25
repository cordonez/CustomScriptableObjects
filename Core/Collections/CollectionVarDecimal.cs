namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarDecimal")]
	[Serializable]
	public class CollectionVarDecimal : BaseCollection<VarDecimal> { }
}