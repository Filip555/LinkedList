using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class AddingElementsToLinkedList
    {
public LinkedList<string> List { get; set; } = new LinkedList<string>();
private LinkedListNode<string> _firstElementOnListWithLowPriority;
private string _firstElementWithLowPriority = "";
public void SaveElementToLinkedList(string command)
{
    if (command.Substring(command.Length - 1, 1) == "1")
    {
        if (List.Count == 0) _firstElementOnListWithLowPriority = null;
        if (_firstElementOnListWithLowPriority != null)
        {
            List.AddBefore(_firstElementOnListWithLowPriority, command);
        }
        else
        {
            List.AddFirst(command);
        }
    }
    else
    {
        List.AddLast(command);
        foreach (var item in List)
        {
            if (item.Substring(item.Length - 1, 1) == "0")
            {
                _firstElementWithLowPriority = item; break;
            };
        }
        _firstElementOnListWithLowPriority = List.Find(_firstElementWithLowPriority);
    }
}

public void SendComunicate()
{
    while (true)
    {
        if (List.Count > 0)
        {
            var firstElement = List.First.Value;
            Console.WriteLine(firstElement);
            List.RemoveFirst();
            continue;
        }
        break;
    }
}
    }
}
