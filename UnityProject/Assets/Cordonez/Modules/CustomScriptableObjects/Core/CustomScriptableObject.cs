using System;
using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	[Serializable]
	public abstract class CustomScriptableObject<T> : BaseCustomScriptableObject
	{
		[SerializeField]
		private T m_value;

		public virtual T Value
		{
			get { return m_value; }
			set { m_value = value; }
		}

		public static implicit operator T(CustomScriptableObject<T> _value)
		{
			return _value.m_value;
		}
	}
}