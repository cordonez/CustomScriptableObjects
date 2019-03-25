namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarVector4")]
	[Serializable]
	public class CollectionVarVector4 : BaseCollection<VarVector4> { }
}