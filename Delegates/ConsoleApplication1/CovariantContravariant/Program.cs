using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovariantContravariant
{
    class X
    {
        public int Val;
    }
    // Y is derived from X.
    class Y : X { }
    // This delegate returns X and takes a Y argument.
    delegate X ChangeIt(Y obj);
    class CoContraVariance
    {
        // This method returns X and has an X parameter.
        static X IncrA(X obj)
        {
            X temp = new X();
            temp.Val = obj.Val + 1;
            return temp;
        }
        // This method returns Y and has a Y parameter.
        static Y IncrB(Y obj)
        {
            Y temp = new Y();
            temp.Val = obj.Val + 1;
            return temp;
        }
        static void Main()
        {
            Y Yob = new Y();
            // In this case, the parameter to IncrA
            // is X and the parameter to ChangeIt is Y.
            // Because of contravariance, the following
            // line is OK.
            ChangeIt change = IncrA;
            X Xob = change(Yob);
            Console.WriteLine("Xob: " + Xob.Val);
            // In the next case, the return type of
            // IncrB is Y and the return type of
            // ChangeIt is X. Because of covariance,
            // the following line is OK.
            change = IncrB;
            Yob = (Y)change(Yob);
            Console.WriteLine("Yob: " + Yob.Val);
        }
    }

}
