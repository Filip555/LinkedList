using LinkedList;
using Xunit;

namespace LinkedListTest
{
    public class AddingElementsToLinkedListTest
    {
        private readonly AddingElementsToLinkedList _listOfElementsWithPriority = new AddingElementsToLinkedList();
        public AddingElementsToLinkedListTest()
        {
            _listOfElementsWithPriority.SaveElementToLinkedList("CleanUp|P=0");
            _listOfElementsWithPriority.SaveElementToLinkedList("WashTheCar|P=0");
            _listOfElementsWithPriority.SaveElementToLinkedList("GoToTraning|P=1");
            _listOfElementsWithPriority.SaveElementToLinkedList("WashTheWindow|P=0");
            _listOfElementsWithPriority.SaveElementToLinkedList("EatDinner|P=1");
        }
        [Fact]
        public void FirstElementShouldBeGoToTraning()
        {
            var result = _listOfElementsWithPriority.List.First.Value;

            Assert.Equal(result, "GoToTraning|P=1");
        }
        [Fact]
        public void LastElementShouldBeWashTheWindow()
        {
            var result = _listOfElementsWithPriority.List.Last.Value;

            Assert.Equal(result, "WashTheWindow|P=0");
        }
    }
}
