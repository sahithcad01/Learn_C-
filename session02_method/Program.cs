// See https://aka.ms/new-console-template for more information
using System;
class Program{

    static void Printstmt(){
         Console.WriteLine("Hello! How are You?");
         Printmsg();
    }

    static void Printmsg(){
         Console.WriteLine("Hii! Yes.!...Fine....");
         Replaymsg();
    }

    static int Replaymsg(){
        Console.WriteLine("where did you come from..?");
        Replaymsg2();
        return 0;
    }

    static string Replaymsg2(){
        Console.WriteLine("Trichy..bro...");
        return " ";
    }

    static void NumsWithoutReturnWithoutParameter(){        //method without return Type without parameter passing
        Console.WriteLine("number access Basics! method without return Type without parameter passing");
        int a=10;
        int b=5;
        Console.WriteLine("Addition of a & b :" + (a+b));
    }

    static int NumsWithReturnWithoutParameter(){           //method with return Type without parameter passing
        Console.WriteLine("number access Basics! method with return Type without parameter passing");
        int a=100;
        int b=40;
        return (a-b);
    }

    static void NumsWithoutReturnWithParameter(int a, int b){           //method without return Type with parameter passing
        Console.WriteLine("number access Basics! method without return Type with parameter passing");
        int mul = a*b;
        Console.WriteLine("Multiplication of a & b :" + mul);
    }

    static int NumsWithReturnWithParameter(int a, int b){           //method with return Type with parameter passing
        Console.WriteLine("number access Basics! method with return Type with parameter passing");
        int div = a/b;
        return div;
    }

    static void Main(string [] args){
        Console.WriteLine("Welcome to C# Main Method");
        Printstmt();
        //m:1
        NumsWithoutReturnWithoutParameter();
        //m:2
        int Sub_Result;
        Sub_Result=NumsWithReturnWithoutParameter();
        Console.WriteLine("Subtraction of a & b :" + Sub_Result);
        //m:3
        NumsWithoutReturnWithParameter(10,5);
        //m:4
        int Div_Result=NumsWithReturnWithParameter(10,2);
        Console.WriteLine("Divition of a & b :" + Div_Result);

        //if-condition:
        if(Sub_Result==Div_Result){
            Console.WriteLine("Equal values!!");
        }
        else if(Sub_Result>Div_Result){
            Console.WriteLine("Subtraction value is high!");
        }
        else{
             Console.WriteLine("Divition value is high!");
        }

        //loop
        int x=5;
        for (int i=0; i<x; i++){
            Console.WriteLine("*");
        }

        //while-loop
        int z=5,k=1;
        while(k<z+1){
            Console.WriteLine("#"+ k);
            k++;
        }
    }

}
