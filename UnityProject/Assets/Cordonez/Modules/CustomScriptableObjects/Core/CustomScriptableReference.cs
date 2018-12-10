namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	using System;
	using UnityEngine;

	[Serializable]
	public class CustomScriptableReference<TConstant, TCustomScriptable> where TCustomScriptable : CustomScriptableObject<TConstant>
	{
		[SerializeField]
		public TCustomScriptable CustomScriptableObject;
		[SerializeField]
		public TConstant ConstantValue;

		public bool UseConstant = true;

		public TConstant Value
		{
			get { return UseConstant ? ConstantValue : CustomScriptableObject.Value; }
			set
			{
				if (UseConstant)
				{
					ConstantValue = value;
				}
				else
				{
					CustomScriptableObject.Value = value;
				}
			}
		}

		public static implicit operator TConstant(CustomScriptableReference<TConstant, TCustomScriptable> _customScriptableReference)
		{
			return _customScriptableReference.Value;
		}
	}
}