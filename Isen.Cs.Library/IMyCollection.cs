using System.Dynamic;

namespace Isen.Cs.Library
{
    public interface IMyCollection
    {
        int Count { get; }
        void Add(string item);
        void InsertAt(int index, string item);

        void RemoveAt(int index);
        string[] Values { get; }

    }
}