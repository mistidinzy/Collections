using System;
using System.Collections;

namespace LendingLibrary
{
  public class Backpack<T> : IBag<T>
  {
    public Backpack()
    {   }

    public IEnumerator<T> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public void Pack(T item)
    {
      throw new NotImplementedException();
    }

    public T Unpack(int index)
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
  }
}

