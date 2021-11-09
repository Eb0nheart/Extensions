using Extensions.Utility;
using System.Collections.ObjectModel;

namespace ExtensionsTests.UtilityTests;

public class CollectionTests
{
    [Test]
    public void RemoveById_WorksWithIntId()
    {
        var objectToDelete = new TestClassWithId { IntId = 1 };
        var testCollection = new Collection<TestClassWithId> { objectToDelete, new() { IntId = 2 }, new() { IntId = 3 } };

        testCollection.RemoveById(objectToDelete.IntId);
        var objectWhichWasSupposedToBeDeleted = testCollection.FirstOrDefault(obj => obj.IntId == objectToDelete.IntId);

        Assert.IsNull(objectWhichWasSupposedToBeDeleted, "Object should have been deleted, and FirstOrDefault should therefore return null!");
    }

    [Test]
    public void RemoveById_WorksWithGuidId()
    {
        var objectToDelete = new TestClassWithId { GuidId = Guid.NewGuid() };
        var testCollection = new Collection<TestClassWithId> { objectToDelete, new() { GuidId = Guid.NewGuid() }, new() { GuidId = Guid.NewGuid() } };

        testCollection.RemoveById(objectToDelete.GuidId);
        var objectWhichWasSupposedToBeDeleted = testCollection.FirstOrDefault(obj => obj.GuidId == objectToDelete.GuidId);

        Assert.IsNull(objectWhichWasSupposedToBeDeleted, "Object should have been deleted, and FirstOrDefault should therefore return null!");
    }
}

public class TestClassWithId
{
    public int IntId { get; set; }

    public Guid GuidId { get; set; }
}