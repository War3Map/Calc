using System;

public class State
{
	public State()
	{

	}

    public Stack<decimal> Memory { get; set; }

    public void AddToMem(decimal number)
    {
        Memory.Push(number);
    }
    public decimal ExtractFromMem() => Memory.Pop();
}
