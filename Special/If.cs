// If -- Parse tree node strategy for printing the special form if

using System;

namespace Tree
{
    public class If : Special
    {
	public If() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printIf(t, n, p);
        }

        /**
        Kristen:
        public Node eval(Node t, Environment e) {
            Node cond = t.getCdr().getCar();
            //
            Node trueblock = t.getCdr().getCdr().getCar();
            Ndoe falseblok = t.getCdr().getCdr().getCdr().getCar();
        //maybe make a nested environment for the condition environment?
            if(cond.eval(e).boolValue()) {
                return trueblock.eval(e);
            } else return falseblock.eval(e);
        }
        */
        /*
        * If: (if condition evaliftrue evaliffalse)
        *
        *
        */
    }
}

