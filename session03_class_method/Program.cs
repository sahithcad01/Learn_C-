// See https://aka.ms/new-console-template for more information
using System;
//new class Operators:
class Operators{
    static void Main(string [] args){
        Console.WriteLine("Give A & B & operator input:");
        int a= Int32.Parse(Console.ReadLine());
        int b= Int32.Parse(Console.ReadLine());
        string sim= Console.ReadLine();
        //2 operand & 1 operator input
        OperatorMethod(a,b,sim);
        //Method Over-Loading:
        //3 operand input
        int c= 10;
        AdditonOperation(a,b,c);
        MultiplicationOperation(a,b,c);
    }

    static void OperatorMethod(int a,int b,string sim){
        switch (sim)
        {
            case("+"):
               AdditonOperation(a,b);
               break;
            case("-"):
               SubtractionOperation(a,b);
               break;
            case("*"):
               MultiplicationOperation(a,b);
               break;
            case("/"):
               DivitionOperation(a,b);
               break;
            default:
               Console.WriteLine(ErrorMsg(sim));
               break;
        }
    }

    static void  AdditonOperation(int a,int b){
        Console.WriteLine("Addition of a & b :" + (a+b));
    }

    static void  SubtractionOperation(int a,int b){
        Console.WriteLine("Subtraction of a & b :"+ (a-b));
    }

    static void  MultiplicationOperation(int a,int b){
        Console.WriteLine("Multiplication of a & b :"+ (a*b));
    }

    static void  DivitionOperation(int a,int b){
        Console.WriteLine("Multiplication of a & b :" + (a/b));
    }

    static string ErrorMsg(string sim){
        return ("Check your Operator "+ sim);
    }

    //Method-Over_Loading:
    static void  AdditonOperation(int a,int b,int c){
        Console.WriteLine("Addition of a, b & c :" + (a+b+c));
    }

     static void  MultiplicationOperation(int a,int b,int c){
        Console.WriteLine("Multiplication of a, b & c :" + (a*b*c));
    }
}
