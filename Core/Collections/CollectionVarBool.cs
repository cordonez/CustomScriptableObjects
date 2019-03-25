namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarBool")]
	[Serializable]
	public class CollectionVarBool : BaseCollection<VarBool> { }
}