// See https://aka.ms/new-console-template for more information


using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

partial class Progarm
{
    delegate void Compute(int n1, int n2);
    delegate void Contarctor(double budget);

    
    static void Main()
    {
  Action<string, bool> Workto = new Action<string, bool> ((work,work1) => { Console.WriteLine($"Coding in c# :{work} and {work1}"); }
        );


        Func<string,string> work3 = (name)=> $"my name is : {name}";
        

        Predicate<int> IsActive = (v) => {

            if (v == 0) return false; else return true;
        };
        Console.WriteLine($"update employee set isactive : {IsActive(1)}");
        Console.WriteLine((work3("dhanush")));
        Workto("kiran",true);

    }

    static void UsingGenericDelegates()
    {
        Action<double> RockyRaniRegisterMarriage = new Action<double>(
            (budget) =>
            {
                Console.WriteLine($"Registration fees and arragngement:{budget * 95 / 100}");
                Console.WriteLine($"Reception charges:{budget * 5 / 100}");
            }
            );

        Func<int, int, string> modifiedCompute = (n1,n2) =>  $"addition :{n1+n2}";
        modifiedCompute += (n1, n2) => $"subtrction :{n1 - n2}";

        Predicate<int> IsActive = (v) => {

            if (v==0) return false; else return true;
        };
        //invoke all above delegates
        RockyRaniRegisterMarriage(5000d);
       Console.WriteLine( modifiedCompute(100, 200));
       Console.WriteLine( $"output of predicate : {IsActive(1)}");

    }

    private static void RockyRaniMarriageDelegate()
    {
        Contarctor RockyRaniMarriage = new Contarctor((b) => Console.WriteLine($"Pandit Charges:{b * 20 / 100}"));
        RockyRaniMarriage += (b) => Console.WriteLine($"Catering Charges:{b * 50 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Mandap Charges:{b * 5 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Couple arrive in porsche reserved for 2days:{b * 15 / 100}");


        RockyRaniMarriage(5000000);
    }

    private static void UsingLamdas()
    {
        //instantiation
        Compute objShortCompute = new Compute((a, b) => Console.WriteLine($"add :{a + b}"));
        objShortCompute += (s, t) => Console.WriteLine($"sub :{s - t}");
        objShortCompute += (c, d) => Console.WriteLine($"mul :{c * d}");
        objShortCompute += (x, y) => Console.WriteLine($"div :{x / y}");

        //Invocation Like calling a function
        objShortCompute(250, -50);
    }

    private static void DelegateUsingLongCutTechnique()
    {
        Compute objCompute = new Compute(AddFn);

        objCompute += SubFn;
        objCompute += MulFn;

        objCompute += DivFn;
        //Invoke the delegate exactly like a function
        objCompute(100, 200);
    }




    static  void AddFn(int n1, int n2)
        {
        Console.WriteLine($"Output of addition :{n1+n2}");
        }

     

   static   void SubFn(int n1, int n2)
        {
         Console.WriteLine($"Output of sub :{n1 - n2}");
        }

      

     static   void MulFn(int n1, int n2)
        {
        Console.WriteLine($"Output of mul :{n1 * n2}");
    }

       

  static      void DivFn(int n1, int n2)
        {
        Console.WriteLine($"Output of division :{n1 / n2}");
    }
    }

