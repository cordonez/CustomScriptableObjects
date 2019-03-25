namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Bool")]
	[Serializable]
	public class CollectionBool : BaseCollection<bool> { }
}