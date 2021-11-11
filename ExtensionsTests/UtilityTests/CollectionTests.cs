using Extensions.Utility;
using System.Collections.ObjectModel;

namespace ExtensionsTests.UtilityTests;

public class CollectionTests
{
    [Test]
    public void RemoveById_WorksWithIntId()
    {
        var objectToDelete = new TestClassWithIntId { Id = 1 };
        var testCollection = new Collection<TestClassWithIntId> { objectToDelete, new() { Id = 2 }, new() { Id = 3 } };

        testCollection.RemoveById(objectToDelete.Id);
        var objectWhichWasSupposedToBeDeleted = testCollection.FirstOrDefault(obj => obj.Id == objectToDelete.Id);

        Assert.IsNull(objectWhichWasSupposedToBeDeleted, "Item should have been deleted, and FirstOrDefault should therefore return null!");
    }

    [Test]
    public void RemoveById_WorksWithGuidId()
    {
        var objectToDelete = new TestClassWithGuidId { Id = Guid.NewGuid() };
        var testCollection = new Collection<TestClassWithGuidId> { objectToDelete, new() { Id = Guid.NewGuid() }, new() { Id = Guid.NewGuid() } };

        testCollection.RemoveById(objectToDelete.Id);
        var objectWhichWasSupposedToBeDeleted = testCollection.FirstOrDefault(obj => obj.Id == objectToDelete.Id);

        Assert.IsNull(objectWhichWasSupposedToBeDeleted, "Item should have been deleted, and FirstOrDefault should therefore return null!");
    }

    [Test]
    public void RemoveById_ThrowsWithDifferentIdTypes()
    {
        var objectToDelete = new TestClassWithGuidId { Id = Guid.NewGuid() };
        var testCollection = new Collection<TestClassWithIntId> { new() { Id = 1 }, new() { Id = 2 }, new() { Id = 3 } };

        Assert.Throws<InvalidOperationException>(() => testCollection.RemoveById(objectToDelete.Id), "It shouldnt be possible to delete an item with Id type which is different");
    }

    [Test]
    public void RemoveById_ThrowsWhenItemTypeDoesntHaveIdProperty()
    {
        var objectToDelete = new TestClassWithoutId();
        var testCollection = new Collection<TestClassWithoutId> { new() { Age = 1 }, new() { Age = 2 }, new() { Age = 3 } };

        Assert.Throws<InvalidOperationException>(() => testCollection.RemoveById(objectToDelete.Age), "It shouldnt be possible to delete an item of a type without property called Id");
    }

    [Test]
    public void RemoveById_ThrowsWhenCalledOnEmptyCollection()
    {
        var testCollection = new Collection<object>();

        Assert.Throws<InvalidOperationException>(() => testCollection.RemoveById(1), "It shouldnt be possible to call Remove on an empty collection");
    }

    [Test]
    public void RemoveById_ThrowsWhenCalledOnNullCollection()
    {
        Collection<object> testCollection = null;

        Assert.Throws<ArgumentNullException>(() => testCollection.RemoveById(1), "It shouldnt be possible to call Remove on a collection which is null");
    }
}

public class TestClassWithIntId
{
    public int Id { get; set; }
}

public class TestClassWithGuidId
{
    public Guid Id { get; set; }
}

public class TestClassWithoutId
{
    public int Age { get; set; }
}
