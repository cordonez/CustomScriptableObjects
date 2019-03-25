namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarVector3")]
	[Serializable]
	public class CollectionVarVector3 : BaseCollection<VarVector3> { }
}