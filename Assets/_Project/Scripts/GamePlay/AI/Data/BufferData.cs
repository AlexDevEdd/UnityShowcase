using System;

namespace GamePlay
{
    [Serializable]
    public struct BufferData<T>
    {
        public T[] Values;
        public int Size;
    }
}