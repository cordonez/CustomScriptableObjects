namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Double")]
	[Serializable]
	public class CollectionDouble : BaseCollection<double> { }
}