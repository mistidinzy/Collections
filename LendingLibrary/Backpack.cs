using System;
using System.Collections;

namespace LendingLibrary
{
  public class Backpack<T> : IBag<T>
  {
    public Backpack()
    { }

    List<T> bag = new List<T>();

    public void Pack(T item)
    {
      bag.Add(item);
    }

    public T Unpack(int index)
    {
      T book = bag.ElementAt<T>(index);
      bag.RemoveAt(index);
      return book;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      for (int i = 0; i < bag.Count; i++)
      {
        yield return bag[i];
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}

