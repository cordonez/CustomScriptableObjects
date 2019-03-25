namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarDouble")]
	[Serializable]
	public class CollectionVarDouble : BaseCollection<VarDouble> { }
}