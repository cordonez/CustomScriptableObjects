namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Vector2")]
	[Serializable]
	public class CollectionVector2 : BaseCollection<Vector2> { }
}