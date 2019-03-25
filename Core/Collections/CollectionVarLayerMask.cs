namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarLayerMask")]
	[Serializable]
	public class CollectionVarLayerMask : BaseCollection<VarLayerMask> { }
}