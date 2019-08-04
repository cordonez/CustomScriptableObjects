using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CustomScriptableObjects.Core.Collections
{
    using System;

    [Serializable]
    public class BaseCollection<T> : BaseVariable<List<T>> { }
}