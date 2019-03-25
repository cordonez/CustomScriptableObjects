namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Float")]
	[Serializable]
	public class VarFloat : BaseVariable<float> { }
}