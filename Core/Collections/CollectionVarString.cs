namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarString")]
	[Serializable]
	public class CollectionVarString : BaseCollection<VarString> { }
}