using System;

namespace Net5ToDo.Core
{
  public class TodoItem
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
  }
}
