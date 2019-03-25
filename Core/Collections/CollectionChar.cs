namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Char")]
	[Serializable]
	public class CollectionChar : BaseCollection<char> { }
}