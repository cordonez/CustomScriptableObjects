namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Vector4")]
	[Serializable]
	public class VarVector4 : BaseVariable<Vector4> { }
}