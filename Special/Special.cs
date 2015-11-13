// Special -- Parse tree node strategy for printing special forms

using System;

namespace Tree
{
    // There are several different approaches for how to implement the Special
    // hierarchy.  We'll discuss some of them in class.  The easiest solution
    // is to not add any fields and to use empty constructors.

    abstract public class Special
    {
        public abstract void print(Node t, int n, bool p);
        //TODO: Make this abstract when all Specials have been implemented
        public virtual Node eval(Node t, Environment env) {
            Console.Error.WriteLine("Error: "+this.GetType().Name+".eval() not yet implemented. Returning Nil...");
            return Nil.getInstance();
        }
    }
}

