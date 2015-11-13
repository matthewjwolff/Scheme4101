// Define -- Parse tree node strategy for printing the special form define

using System;

namespace Tree
{
    public class Define : Special
    {
	public Define() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printDefine(t, n, p);
        }
        /**
        Define:
        (define var value)
        (define (func params) ...eval list... )
           > (define func (lambda (params) ...eval list...))
        */
    }
}


