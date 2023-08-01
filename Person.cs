using System;

namespace compsite
{
    public class Person
    {
         private string name;
    private List<Person> children;

    public Person(string name)
    {
        this.name = name;
        this.children = new List<Person>();
    }

    public void AddChild(Person child)
    {
        children.Add(child);
    }

    public override string ToString()
    {
        string result = name;

        if (children.Count > 0)
        {
            result += " (";
            for (int i = 0; i < children.Count; i++)
            {
                result += children[i].ToString();
                if (i < children.Count - 1)
                {
                    result += ", ";
                }
            }
            result += ")";
        }

        return result;
    }
    }
}
