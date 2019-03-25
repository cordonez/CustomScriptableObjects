namespace CustomScriptableObjects.Core.Variables
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(menuName = MenuPath.VARIABLES + "Decimal")]
	[Serializable]
	public class VarDecimal : BaseVariable<decimal> { }
}