namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Vector3")]
	[Serializable]
	public class CollectionVector3 : BaseCollection<Vector3> { }
}