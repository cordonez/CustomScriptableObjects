namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;
	using Variables;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "VarScene")]
	[Serializable]
	public class CollectionVarScene : BaseCollection<VarScene> { }
}