// Regular -- Parse tree node strategy for printing regular lists

using System;

namespace Tree
{
    public class Regular : Special
    {
        public Regular() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printRegular(t, n, p);
        }

        public override Node eval(Node t, Environment env)
        {
            Node car = t.getCar().eval(env);
            Node cdr = t.getCdr().eval(env);
            if (t.getCar().isSymbol())
            {
                //Will be evaluated to a procedure(?)
                return car.apply(cdr);
            }
            else return new Cons(car,cdr);
            /**
            Node car = t.getCar().eval(env);
            //Get the argument list
            Node cdr = t.getCdr();
            //Evaluate each argument, and replace the argument with its evaluated value
            while(cdr != Nil.getInstance())
            {
                cdr.setCar(cdr.getCar().eval(env));
                cdr = cdr.getCdr();
            }
            return car.apply(t.getCdr());
            */
        }
        /**
            node = (something that was passed in during the constructor, figure out what it is later
            node.eval(param, env)
            

        */
        //Functions are given the regular form
        /**
        closure(fac).apply((5))
        .
       / \
     foo


    */
    }
}


