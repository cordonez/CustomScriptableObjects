namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Int")]
	[Serializable]
	public class CollectionInt : BaseCollection<int> { }
}