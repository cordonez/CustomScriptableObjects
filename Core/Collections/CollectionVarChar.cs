namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarChar")]
	[Serializable]
	public class CollectionVarChar : BaseCollection<VarChar> { }
}