namespace CustomScriptableObjects.Core.References
{
	using System;
	using UnityEngine;

	[Serializable]
	public class BaseReference<TConstant, TVariable> where TVariable : BaseVariable<TConstant>
	{
		[SerializeField]
		public TVariable Variable;
		[SerializeField]
		public TConstant Constant;

		public bool UseConstant = true;

		public TConstant Value
		{
			get => UseConstant ? Constant : Variable.Value;
			set
			{
				if (UseConstant)
				{
					Constant = value;
				}
				else
				{
					Variable.Value = value;
				}
			}
		}

		public static implicit operator TConstant(BaseReference<TConstant, TVariable> _reference)
		{
			return _reference.Value;
		}
	}
}