using System;

namespace Prog_lab6
{
	public class Demo
	{
		static void Main(string[] args)
		{
			Console.Write("--------Fio class--------\n");
			/*
			Console.Write("------Constructors-------\n");
			Fio fio1 = new Fio();
			fio1.Display();
			Fio fio2 = new Fio("Popov");
			fio2.Display();
			Fio fio3 = new Fio("Ivanov", "Sergey", "Ivanovich");
			fio3.Display();

			Console.Write("\n-----Array of objects with constructor----\n");
			Fio[] arrFio = new Fio[3];
			for (int i = 0; i < 3; i++)
			{ 
				arrFio[i] = new Fio("stated");
				arrFio[i].Display();
			}
			*/
			
			Console.Write("---Read method---\n");
			Fio myFio = new Fio();
			myFio.Read();
			myFio.Display();
				
			/*
			Console.Write("\n------Set methods-------\n");
			if ((myFio.SetSurname("Ivanov")) || (myFio.SetName("Ivan")) || (myFio.SetPatronymic("Ivanovich")))
				Console.Write("error\n");
			else
				myFio.Display();
			*/
			/*
			Console.Write("------set-properties demo-------\n");
			myFio.Surname = "Sidorov";
			myFio.Name = "Oleg";
			myFio.Patronymic = "Litvinovich";
			myFio.Display();

			Console.Write("------get-properties demo-------\n");
			Fio demoFio = new Fio();
			demoFio.Init(myFio.Surname, myFio.Name, myFio.Patronymic);
			demoFio.Display();
			*/

			/*
			Console.Write("\n---class and struct difference---\n");
			Fio myFio = new Fio();
			myFio.Surname = "Komolov";
			myFio.Name = "Oleg";
			myFio.Patronymic = "Victorovich";
			Console.Write("\nmyFio class:\n");
			myFio.Display();

			Fio demoFio = new Fio();
			demoFio.Surname = "Anosov";
			demoFio.Name = "Aleksandr";
			demoFio.Patronymic = "Ivanovich";
			Console.Write("\ndemoFio class:\n");
			demoFio.Display();

			Console.Write("\nResult of demoFio = myFio is\n");
			demoFio = myFio;
			demoFio.Display();

			myFio.Init("Stepanov", "Maksim", "Olegovich");
			Console.Write("\nmyFio class after change:\n");
			myFio.Display();

			Console.Write("\nFinal value of demoFio:\n");
			demoFio.Display();
			*/

			Console.Write("\n--------Human class--------\n");
			/*
			Console.Write("------Constructors-------\n");
			Human human1 = new Human();
			human1.Display();
			Human human2 = new Human(13);
			human2.Display();
			Human human3 = new Human(13, 45, 190, 90, 'M', fio3);
			human3.Display();

			Console.Write("\n-----Array of objects with constructor----\n");
			Human[] arrHuman = new Human[3];
			for (int i = 0; i < 3; i++)
			{
				arrHuman[i] = new Human(i);
				arrHuman[i].Display();
			}
			*/
			Console.Write("------Read method------\n");
			Human myHuman = new Human();
			myHuman.Read();
			myHuman.Display();
				
			/*
			Console.Write("\n------Set methods-------\n");
			if (myHuman.SetId(1999) || myHuman.SetAge(27) || myHuman.SetHeight(180) ||
				myHuman.SetWeight(80.890) || myHuman.SetGender('M'))
				Console.Write("error\n");
			else
				myHuman.Display();
			*/
			/*
			Console.Write("------set-properties demo-------\n");
			myHuman.Id = 2000;
			myHuman.Age = 40;
			myHuman.Height = 190;
			myHuman.Weight = 86.190;
			myHuman.Gender = 'M';
			myHuman.FioField = demoFio;
			myHuman.Display();

			Console.Write("------get-properties demo-------\n");
			Human demoHuman = new Human();
			demoHuman.Init(myHuman.Id, myHuman.Age, myHuman.Height, myHuman.Weight, myHuman.Gender, myHuman.FioField);
			demoHuman.Display();
			*/


			Console.Write("\n--------Student class--------\n");
			/*
			Console.Write("------Constructors-------\n");
			Student student1 = new Student();
			student1.Display();
			Student student2 = new Student(human2);
			student2.Display();
			Student student3 = new Student(2, "Bachelor", "PI-03", "FoIT", human3);
			student3.Display();

			Console.Write("\n-----Array of objects with constructor----\n");
			Student[] arrStudent = new Student[3];
			for (int i = 0; i < 3; i++)
			{
				arrStudent[i] = new Student(human2);
				arrStudent[i].Display();
			}
			*/

			Console.Write("------Read method------\n");
			Student myStudent = new Student();
			myStudent.Read();
			myStudent.Display();

			/*
			Console.Write("\n------Set methods-------\n");
			if (myStudent.SetCourse(4) || myStudent.SetEduProg("Master") ||
				myStudent.SetGroup("CS-91") ||
				myStudent.SetFacultyName("FoIT"))
				Console.Write("error\n");
			else
				myStudent.Display();
			*/
			/*
			Console.Write("------set-properties demo-------\n");
			myStudent.Course = 1;
			myStudent.EduProg = "Bachelor";
			myStudent.Group = "WS-34";
			myStudent.FacultyName = "FoHS";
			myStudent.HumanField = demoHuman;
			myStudent.Display();

			Console.Write("------get-properties demo-------\n");
			Student demoStudent = new Student();
			demoStudent.Init(myStudent.Course, myStudent.EduProg, myStudent.Group, myStudent.FacultyName, myStudent.HumanField);
			demoStudent.Display();
			*/


			Console.Write("\n--------Teacher class--------\n");
			/*
			Console.Write("------Constructors-------\n");
			Teacher teacher1 = new Teacher();
			teacher1.Display();
			Teacher teacher2 = new Teacher(human2);
			teacher2.Display();
			Teacher teacher3 = new Teacher(18, "Candidate of Mathemetical Sciences", "FoMS", human3);
			teacher3.Display();

			Console.Write("\n-----Array of objects with constructor----\n");
			Teacher[] arrTeacher = new Teacher[3];
			for (int i = 0; i < 3; i++)
			{
				arrTeacher[i] = new Teacher(human2);
				arrTeacher[i].Display();
			}
			*/

			Console.Write("------Read method------\n");
			Teacher myTeacher = new Teacher();
			myTeacher.Read();
			myTeacher.Display();

			/*
			Console.Write("\n------Set methods-------\n");
			if (myTeacher.SetWorkExp(30) || myTeacher.SetDegree("Doctor of Mathematical Sciences") || myTeacher.SetFacultyName("SMTH"))
				Console.Write("error\n");
			else
				myTeacher.Display();
			*/
			/*
			Console.Write("------set-properties demo-------\n");
			myTeacher.WorkExp = 20;
			myTeacher.Degree = "Candidate of Historical Sciences";
			myTeacher.FacultyName = "FoHS";
			myTeacher.HumanField = demoHuman;
			myTeacher.Display();

			Console.Write("------get-properties demo-------\n");
			Teacher demoTeacher = new Teacher();
			demoTeacher.Init(myTeacher.WorkExp, myTeacher.Degree, myTeacher.FacultyName, myTeacher.HumanField);
			demoTeacher.Display();

			Console.Write("\n----operator overloading demo----\n");
			Console.Write("demoTeacher.WorkExp = {0}\n",demoTeacher.WorkExp);
			
			demoTeacher = demoTeacher + 3;
			Console.Write("\ndemoTeacher + 3 = new object of Teacher class:\n", demoTeacher);
			demoTeacher.Display();

			Console.Write("\n4 + demoTeacher  = {0} of int\n", 4 + demoTeacher);

			Console.Write("\ndemoTeacher++ = new object of Teacher class\n");
			demoTeacher++;
			demoTeacher.Display();

			Console.Write("\n++demoTeacher = new object of Teacher class\n");
			++demoTeacher;
			demoTeacher.Display();
			*/
			/*
			Console.Write("\nStatic method demo\n");
			Fio myFio = new Fio();
			myFio.Init("Popov", "Alexandr", "Dmitrievich");
			Human myHuman = new Human();
			myHuman.Init(1913, 43, 182, 70.89, 'F', myFio);
			Teacher myTeacher = new Teacher();
			myTeacher.Init(18, "Candidate of Mathematical Sciences", "FoMS", myHuman);
			Console.Write("Teacher:\n");
			myTeacher.Display();
			Console.Write("\nAnd his salary is...\n");
			Console.Write(Teacher.GetSalaryOf(myTeacher));
			*/

			Console.Write("\n--------Faculty class--------\n");
			/*
			Console.Write("------Constructors-------\n");
			Faculty faculty1 = new Faculty();
			faculty1.Display();
			Faculty faculty2 = new Faculty("FoMS");
			faculty2.Display();
			Faculty faculty3 = new Faculty("FoMS", 200, 180, 20, 40, 30, 10, 30);
			faculty3.Display();

			Console.Write("\n-----Array of objects with constructor----\n");
			Faculty[] arrFaculty = new Faculty[3];
			for (int i = 0; i < 3; i++)
			{
				arrFaculty[i] = new Faculty("stated");
				arrFaculty[i].Display();
			}
			*/
			/*
			Console.Write("\n------Shortcut-set methods-------\n");
			myFaculty.SetStudentsInfo(300, 270, 30);
			myFaculty.SetTeachersInfo(40, 33, 7);
			if (myFaculty.SetFacultyName("Fo****IT"))
				Console.Write("Error\n");
			else
				myFaculty.Display();
			*/

			Console.Write("------Read method------\n");
			Faculty myFaculty = new Faculty();
			myFaculty.Read();
			myFaculty.Display();

			try
			{
				Console.Write("\n----processing by methods----\n");
				Console.Write("Procent of masters on faculty: {0:f2}\n", myFaculty.GetProcentOfMasters());
				Console.Write("Procent of doctors on faculty: {0:f2}\n", myFaculty.GetProcentOfDoctors());
				Console.Write("Students to teachers quantity: {0:f2}\n", myFaculty.GetStudToTeachRatio());
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}

			/*
			Console.Write("------set-properties demo-------\n");
			myFaculty.FacultyName = "FoHS";
			myFaculty.QuantityOfStudents = 300;
			myFaculty.QuantityOfBachelors = 200;
			myFaculty.QuantityOfMasters = 100;
			myFaculty.QuantityOfTeachers = 50;
			myFaculty.QuantityOfCandidates = 35;
			myFaculty.QuantityOfDoctors = 15;
			myFaculty.QuantityOfDisciplines = 40;
			myFaculty.Display();

			Console.Write("------get-properties demo-------\n");
			Faculty demoFaculty = new Faculty();
			demoFaculty.Init(myFaculty.FacultyName, myFaculty.QuantityOfStudents, 
				myFaculty.QuantityOfBachelors, myFaculty.QuantityOfMasters, myFaculty.QuantityOfTeachers, 
				myFaculty.QuantityOfCandidates, myFaculty.QuantityOfDoctors, myFaculty.QuantityOfDisciplines);
			myFaculty.Display();
			*/

			/*
			Console.Write("\n------array of objects------\n");
			int sumOfStudents = 0;
			Random rnd = new Random();

			Faculty[] objArray = new Faculty[3];
			for (int i = 0; i < objArray.Length; i++)
			{
				objArray[i] = new Faculty();
				objArray[i].Init("smth", rnd.Next(500),
						rnd.Next(450), rnd.Next(50),
						rnd.Next(100), rnd.Next(80),
						rnd.Next(20), rnd.Next(50));
				sumOfStudents += objArray[i].GetQuantityOfStudents();
				objArray[i].Display();
			}
			Console.Write("\nTotal quantity of students on all faculties: {0}\n", sumOfStudents);
			Console.Write("\nLet's compare first and second faculties to find the one...\n");
			Console.Write("...that have the largest number of candidates on it.\n");
			Console.Write("And the answer is:\n");
			objArray[0].GetWithMoreCandidates(objArray[1]).Display();
			*/
			/*
			Console.Write("\n-------ref-out-expressions-----\n");
			myFaculty.IsHavingMoreStudentsThen(out int myResult);
			Console.Write("Out-expression working result = {0}\n", myResult);

			int demoResult = 4;
			myFaculty.IsHavingMoreTeachersThen(ref demoResult);
			Console.Write("Ref-expression working result = {0}\n", demoResult);
			*/

			Console.ReadKey();
		}
	}
}
