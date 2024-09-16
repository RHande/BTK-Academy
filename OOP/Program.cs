// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Intrinsics.X86;

//Classes
namespace MyStudents
{
   class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FullName = "John Doe";
            s1.StudentID = 1234;
            s1.Branch = "Computer Science";
            //This is the same as
            //Student s1 = new Student() { FullName = "John Doe", StudentID = 1234, Branch = "Computer Science" };
            
            Student s2 = new Student();
            s2.FullName = "Jane Doe";
            s2.StudentID = 5678;
            s2.Branch = "Information Technology";
            
            Student s3 = new Student();
            s3.FullName = "James Doe";
            s3.StudentID = 91011;
            s3.Branch = "Computer Science";
            
            Console.WriteLine($"The student has {s1.StudentID} ID, his name is {s1.FullName}, he is studying {s1.Branch}");
            Console.WriteLine($"The student has {s2.StudentID} ID, her name is {s2.FullName}, she is studying {s2.Branch}");
            Console.WriteLine($"The student has {s3.StudentID} ID, his name is {s3.FullName}, he is studying {s3.Branch}");
            
            //Array of students
            Student[] students = new Student[3];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            //This is the same as
            //Student[] students = new Student[] { s1, s2, s3 };
            
            foreach (Student s in students)
            {
               string result = s.PrintStudentInfo();//We called the PrintStudentInfo method and stored the result in a variable called result.
               Console.WriteLine(result);
               //Same as
                //Console.WriteLine(s.PrintStudentInfo());
            }

            var q1 = new Questions()
            {
                Question = "Which is not a programming language?",
                Choises = new string[4] { "C#", "Java", "Python", "HTML" },
                Answer = "HTML"
            };
            
            var q2 = new Questions()
            {
                Question = "Which is the most popular programming language?",
                Choises = new string[4] { "C#", "Java", "Python", "HTML" },
                Answer = "C#"
            };
            
            var q3 = new Questions()
            {
                Question = "Which is not a web programming platform?",
                Choises = new string[4] { "Django", "ASP.Net", "Python", "Spring" },
                Answer = "Python"
            };
            
            /*var quetions = new Questions[] { q1, q2, q3 };
            foreach (var question in quetions)
            {
                Console.WriteLine(question.Question);
                foreach (var choise in question.Choises)
                {
                    Console.WriteLine(choise);
                }
            //We added the following code to check the answers.
                Console.Write("Enter your answer:");
                string answer = Console.ReadLine();
                
                if(question.CheckAnswer(answer))
                {
                    Console.WriteLine("Correct answer!");
                }
                else
                {
                    Console.WriteLine("Wrong answer!");
                }
            }
            */
            Console.WriteLine(q1.PrintQuestion());
            Console.WriteLine(q2.PrintQuestion());
            Console.WriteLine(q3.PrintQuestion());
        }
    }
//First, we created a class called Student. This class has three properties: FullName, StudentID, and Branch.
//Then, we created a method called PrintStudentInfo that prints the student's information.    
    class Student
    {
        public string FullName { get; set; }
        public int StudentID { get; set; }
        public string Branch { get; set; }
        
        //Methods
        
        
        /*
         public void PrintStudentInfo()
         {
               Console.WriteLine($"The student has {this.StudentID} ID, his name is {this.FullName}, he is studying {this.Branch}");
           }
         */
        public string PrintStudentInfo()//We changed the return type of the method from void to string. Because methods that return a value must have a return type.
        {
            return $"The student has {this.StudentID} ID, his name is {this.FullName}, he is studying {this.Branch}";
        }
    }
}

    class Questions{ 
          
          public Questions()
          {
              this.ID = (new Random()).Next(11111, 99999);
          }
          public int ID { get; set; }
          public string Question { get; set; }
          public string[] Choises { get; set; }
          public string Answer { get; set; }
          
          public bool CheckAnswer(string answer)
          {
              return this.Answer == answer;
          }
          
          public string PrintQuestion()
          {
              string question = this.Question + "\n";
                foreach (var choise in this.Choises)
                {
                    question += choise + "\n";
                }
                return question;
          }
          
          
          
          
}






//First version of the code:

/*
namespace MyStudents
   {
      class Program
       {
           static void Main(string[] args)
           {
               Student s1 = new Student();
               s1.FullName = "John Doe";
               s1.StudentID = 1234;
               s1.Branch = "Computer Science";
               //This is the same as
               //Student s1 = new Student() { FullName = "John Doe", StudentID = 1234, Branch = "Computer Science" };
               
               Student s2 = new Student();
               s2.FullName = "Jane Doe";
               s2.StudentID = 5678;
               s2.Branch = "Information Technology";
               
               Student s3 = new Student();
               s3.FullName = "James Doe";
               s3.StudentID = 91011;
               s3.Branch = "Computer Science";
               
               Console.WriteLine($"The student has {s1.StudentID} ID, his name is {s1.FullName}, he is studying {s1.Branch}");
               Console.WriteLine($"The student has {s2.StudentID} ID, her name is {s2.FullName}, she is studying {s2.Branch}");
               Console.WriteLine($"The student has {s3.StudentID} ID, his name is {s3.FullName}, he is studying {s3.Branch}");
               
               //Array of students
               Student[] students = new Student[3];
               students[0] = s1;
               students[1] = s2;
               students[2] = s3;
               //This is the same as
               //Student[] students = new Student[] { s1, s2, s3 };
               
               foreach (Student s in students)
               {
                   Console.WriteLine($"The student has {s.StudentID} ID, his name is {s.FullName}, he is studying {s.Branch}");
               }
           }
       }
       
       class Student
       {
           public string FullName { get; set; }
           public int StudentID { get; set; }
           public string Branch { get; set; }
           
           //Methods
           
           public void PrintStudentInfo()
           {
               Console.WriteLine($"The student has {StudentID} ID, his name is {FullName}, he is studying {Branch}");
           }
       }
   }
 */




