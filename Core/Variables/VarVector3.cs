namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Vector3")]
	[Serializable]
	public class VarVector3 : BaseVariable<Vector3> { }
}