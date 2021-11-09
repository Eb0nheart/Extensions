using System.Collections.ObjectModel;

namespace Extensions.Utility;

public static class CollectionUtility
{
    public static void RemoveById<T>(this Collection<T> collection, int id) where T : class, new()
    {

    }

    public static void RemoveById<T>(this Collection<T> collection, Guid id) where T : class, new()
    {

    }
}