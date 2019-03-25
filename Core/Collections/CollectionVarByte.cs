namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarByte")]
	[Serializable]
	public class CollectionVarByte : BaseCollection<VarByte> { }
}