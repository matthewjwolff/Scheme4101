// Set -- Parse tree node strategy for printing the special form set!

using System;

namespace Tree
{
    public class Set : Special
    {
	public Set() { }
	
        public override void print(Node t, int n, bool p)
        {
            Printer.printSet(t, n, p);
        }

        public override Node eval(Node t, Environment env)
        {
            //arg1: set!
            //arg2: variable
            //arg3: value
            env.assign(t.getCdr().getCar(), t.getCdr().getCdr().getCar().eval(env));
            return NothingNode.getInstance();
        }
    }
}

