using System;

public class myClass
{
    public delegate void MentionDiscount(int subTotal); //interface
    public myClass()
	{
	}
    public int GenerateTotal(MentionDiscount mentionDiscount)
    {

        int value = 6;
        mentionDiscount(value);
        return value;
    }
}
