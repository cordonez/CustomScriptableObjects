namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarUnityObject")]
	[Serializable]
	public class CollectionVarUnityObject : BaseCollection<VarUnityObject> { }
}