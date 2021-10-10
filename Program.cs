using System;
enum Menu{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPerson
}
namespace MT
{
    class Program
    {
        static PersonList personList;

        static void Main(string[] args){
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }

        static void PreparePersonListWhenProgramIsLoad(){
            Program.personList = new PersonList();
        }

        static void PrintMenuScreen(){
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void InputMenuFromKeyboard(){
            Console.Write("Please select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        
        static void PrintHeader(){
            Console.WriteLine("Welcome to registation new user school application");
            Console.WriteLine("--------------------------------------------------");
        }

        static void PrintListMenu(){
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new teacher.");
            Console.WriteLine("3. Get List Person.");

        }

        static void PrintHeaderRegisterStudent(){
            Console.WriteLine("Register new Student");
            Console.WriteLine("--------------------");
        }

        static void PrintHeaderRegisterTeacher(){
            Console.WriteLine("Register new Teacher");
            Console.WriteLine("--------------------");
        }

        static void PresentMenu(Menu menu){
            if(menu == Menu.RegisterNewStudent){
                ShowInputRegistrationNewStudentScreen();
            }else if (menu == Menu.RegisterNewTeacher){
                ShowInputRegistrationNewTeacherScreen();
            }else if (menu == Menu.GetListPerson){
                ShowGetListPersonScreen();
            }else{
                ShowMessageInputMenuIsInCorrect();
            }
        }

        static void ShowGetListPersonScreen(){
            Console.Clear();
            Program.personList.FetchPersonList();
            InputExitFromKeyboard();
        }
        static void InputExitFromKeyboard(){
            string text = "";

            while (text != "exit")
            {
                 Console.Write("Input: ");
                 text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void ShowInputRegistrationNewTeacherScreen(){
            Console.Clear();
            PrintHeaderRegisterTeacher();

            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }
         
        static void InputNewTeacherFromKeyboard(int totalTeacher){
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Teacher teacher = CreateNewTeacher();

                Program.personList.AddNewPerson(teacher);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static Teacher CreateNewTeacher(){
            return new Teacher(InputName(),
            InputAge(),
            InputGender(),
            InputAddress(),
            InputCitizenID(),
            InputStudentID(),
            InputEmployeeID());
        }


        static int TotalNewTeacher(){
            Console.Write("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());

        }

        static void ShowInputRegistrationNewStudentScreen(){
            Console.Clear();
            PrintHeaderRegisterStudent();

            int totalStudent = TotalNewStudent();

            InputNewStudentFromKeyboard(totalStudent);
        }

        static void InputNewStudentFromKeyboard(int totalStudent){
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                Student student = CreateNewStudent();

                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static Student CreateNewStudent(){
            return new Student(InputName(),
            InputAge(),
            InputGender(),
            InputAddress(),
            InputCitizenID(),
            InputStudentID());
        }

        static string InputName(){
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputAge(){
            Console.Write("Age: ");

            return Console.ReadLine();
        }
       
        static string InputGender(){
            Console.Write("Gender: ");

            return Console.ReadLine();
        }
        
        static string InputAddress(){
            Console.Write("Address: ");

            return Console.ReadLine();
        }
        
        static string InputCitizenID(){
            Console.Write("CitizenID: ");

            return Console.ReadLine();
        }
        
        static string InputStudentID(){
            Console.Write("StudentID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID(){
            Console.Write("EmployeeID: ");

            return Console.ReadLine();
        }

        static int TotalNewStudent(){
            Console.Write("Input total new student: ");

            return int.Parse(Console.ReadLine());
        }

        static void ShowMessageInputMenuIsInCorrect(){
            Console.Clear();
            Console.WriteLine("Menu incorrect Please try again");

            InputMenuFromKeyboard();

        }

    }
}
