// Let -- Parse tree node strategy for printing the special form let

using System;

namespace Tree
{
    public class Let : Special
    {
	public Let() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printLet(t, n, p);
        }

        public override Node eval(Node t, Environment env)
        {
            Node bindings = t.getCdr().getCar();
            Environment sub = new Environment(env);
            //bind new stuff
            while(bindings != Nil.getInstance())
            {
                Node pair = bindings.getCar();
                sub.define(pair.getCar(), pair.getCdr().getCar().eval(sub));
                bindings = bindings.getCdr();
            }
            Node function = t.getCdr().getCdr().getCar();
            return function.eval(sub);
        }
    }
}


