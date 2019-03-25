namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarFloat")]
	[Serializable]
	public class CollectionVarFloat : BaseCollection<VarFloat> { }
}