using System;

namespace Task
{
    public class TaskGenerator
   {
       private static TaskGenerator _obj;
       private TaskGenerator()
       {
           // prevents instantiation from external entities
       }
       public static TaskGenerator GetObject() // instead of creating new operator, declare a method and that will create object and return it.
       {
           if (_obj == null) // Checking if the instance is null, then it will create new one and return it 
           {
               _obj = new TaskGenerator();
           }
           // otherwise it will return previous one.
           return _obj;
       }
       public void Generate(double playerKnowledge, string type)
       {


       }
   }
}
