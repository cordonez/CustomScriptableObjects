namespace CustomScriptableObjects.Core
{
    using System;
    using UnityEngine;

    [Serializable]
    public abstract class BaseVariable<T> : BaseScriptableObject
    {
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
                m_onValueUpdated?.Invoke(oldValue, Value);
            }
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