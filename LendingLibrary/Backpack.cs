using System;
using System.Collections;

namespace LendingLibrary
{
  public class Backpack<T> : IBag<T>
  {
    public Backpack()
    {   }

    List<T> bag = new List<T>();

    public IEnumerator<T> GetEnumerator()
    {
      throw new NotImplementedException();
    }

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
      throw new NotImplementedException();
    }
  }
}

