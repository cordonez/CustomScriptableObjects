namespace CustomScriptableObjects.Core.Collections
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.COLLECTIONS + "Vector4")]
	[Serializable]
	public class CollectionVector4 : BaseCollection<Vector4> { }
}