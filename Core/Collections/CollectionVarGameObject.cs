namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarGameObject")]
	[Serializable]
	public class CollectionVarGameObject : BaseCollection<VarGameObject> { }
}