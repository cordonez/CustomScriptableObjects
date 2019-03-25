namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "String")]
	[Serializable]
	public class CollectionString : BaseCollection<string> { }
}