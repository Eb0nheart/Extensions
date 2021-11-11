using System.Collections.ObjectModel;
using System.Reflection;
using System.Text.Json;

namespace Extensions.Utility;

public static class CollectionUtility
{
    /// <summary>
    /// Removes an item with an ID matching the provided ID. <para/>
    /// This method has a few requirements to work: <para/>
    /// 1. <paramref name="collection"/> cannot be empty (duh), and this method will throw an exception if it is! <para/>
    /// 2. <typeparamref name="TItem"/> has to have a property named Id, with that exact casing! <para/>
    /// 3. <typeparamref name="TItem"/>'s Id property has to be of type <typeparamref name="TId"/>
    /// </summary>
    /// <typeparam name="TItem">Type of the items in the collection</typeparam>
    /// <typeparam name="TId">Type of the provided Id property</typeparam>
    /// <param name="collection">Collection to remove an item with matching Id from</param>
    /// <param name="id">ID belonging to item which is to be deleted</param>
    public static void RemoveById<TItem, TId>(this Collection<TItem> collection, TId id) where TItem : class, new()
    {
        ValidateCollection(collection);

        var item = collection.FirstOrDefault(item =>
        {
            var property = GetValidatedProperty(item, typeof(TId));

            return ComparePropertyToInput(property.GetValue(item), id);
        });

        collection.Remove(item);
    }

    private static void ValidateCollection<T>(Collection<T> collection) where T : class, new()
    {
        _ = collection ?? throw new ArgumentNullException(nameof(collection));
        if (!collection.Any())
        {
            throw new InvalidOperationException($"{nameof(collection)} was empty");
        }
    }

    private static PropertyInfo GetValidatedProperty<T>(T item, Type targetType) where T : class, new()
    {
        var property = item.GetType().GetProperty("Id");

        if(property == null)
        {
            throw new InvalidOperationException($"{item.GetType().Name} does not contain a property with the name: Id");
        }

        if (property.PropertyType != targetType)
        {
            throw new InvalidOperationException($"Id property is not of the type {targetType.Name}");
        }

        return property;
    }

    private static bool ComparePropertyToInput(object property, object input)
        => JsonSerializer.Serialize(property) == JsonSerializer.Serialize(input);
}