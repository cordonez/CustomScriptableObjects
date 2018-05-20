using System;
using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	[Serializable]
	public abstract class CustomScriptableObject<T> : BaseCustomScriptableObject
	{
		[SerializeField]
		private T m_value;

		public virtual void SetValue(T _newValue)
		{
			m_value = _newValue;
		}

		public virtual T GetValue()
		{
			return m_value;
		}

		public static implicit operator T(CustomScriptableObject<T> _value)
		{
			return _value.m_value;
		}
	}
}