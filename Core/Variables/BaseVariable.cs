﻿namespace CustomScriptableObjects.Core
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;

	[Serializable]
	public abstract class BaseVariable<T> : BaseScriptableObject
	{
		[SerializeField]
		protected Dictionary<MonoBehaviour, T> m_instanceValues = new Dictionary<MonoBehaviour, T>();

		[SerializeField]
		protected T m_value;

		[SerializeField]
		protected Action<T, T> m_onValueUpdated;

		public virtual T Value
		{
			get => m_value;
			set
			{
				T oldValue = m_value;
				m_value = value;
				if (m_onValueUpdated != null)
				{
					m_onValueUpdated(oldValue, Value);
				}
			}
		}

		public virtual T this[MonoBehaviour _owner]
		{
			get
			{
				if (!m_instanceValues.ContainsKey(_owner))
				{
					m_instanceValues[_owner] = m_value;
				}

				return m_instanceValues[_owner];
			}
			set => m_instanceValues[_owner] = value;
		}

		public virtual bool LiberateInstance(MonoBehaviour _owner)
		{
			return m_instanceValues.Remove(_owner);
		}

		public void AddListenerOnUpdate(Action<T, T> _callback)
		{
			m_onValueUpdated += _callback;
		}

		public void RemoveListenerOnUpdate(Action<T, T> _callback)
		{
			m_onValueUpdated -= _callback;
		}

		public static implicit operator T(BaseVariable<T> _value)
		{
			return _value.Value;
		}
	}
}