package Prog_lab10_java;

import java.util.*;

public class Student
{
	//Attributes
	private int course;  
	private	String eduProg;
	private String group;
	private String facultyName;
	public Human humanField;

	//Constructors
	public Student()
	{
		course = 0;
		eduProg = "unstated";
		group = "unstated";
		facultyName = "unstated";
		humanField = new Human();
	}

	public Student(Human bufHuman)
	{
		course = 0;
		eduProg = "unstated";
		group = "unstated";
		facultyName = "unstated";
		humanField = new Human(bufHuman.getId(), bufHuman.getAge(),
				bufHuman.getHeight(), bufHuman.getWeight(),
				bufHuman.getGender(), bufHuman.fioField);
	}

	public Student(int bufCourse, String bufEduProg, String bufGroup, String bufFacultyName, Human bufHuman)
	{
		Student check = new Student();

		if (check.setCourse(bufCourse) || check.setEduProg(bufEduProg) || check.setGroup(bufGroup) ||
				check.setFacultyName(bufFacultyName))
		{
			course = 0;
			eduProg = "unstated";
			group = "unstated";
			facultyName = "unstated";
			humanField = new Human();
		}
		else
		{
			setCourse(bufCourse);
			setEduProg(bufEduProg);
			setGroup(bufGroup);
			setFacultyName(bufFacultyName);
			humanField = new Human(bufHuman.getId(), bufHuman.getAge(),
					bufHuman.getHeight(), bufHuman.getWeight(),
					bufHuman.getGender(), bufHuman.fioField);
		}
	}

	//Methods with exceptions
	public void hardSetCourse(int buf)
	{
		if (buf < 0 || buf > 6)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			course = buf;
	}

	public void hardSetEduProg(String bufString)
	{
		if (bufString.isEmpty())
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if(bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		eduProg = eduProg.copyValueOf(bufString.toCharArray());
	}

	public void hardSetGroup(String bufString)
	{
		if (bufString.isEmpty())
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");

		String invalidSymbStr = "!@#$%^&*()_+=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if(bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		group = group.copyValueOf(bufString.toCharArray());
	}

	public void hardSetFacultyName(String bufString)
	{
		if (bufString.isEmpty())
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if(bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		facultyName = facultyName.copyValueOf(bufString.toCharArray());
	}

	//Methods
	public boolean setCourse(int buf)
	{
		if (buf < 0 || buf > 6)
			return (true);
		else
		{
			course = buf;
			return (false);
		}
	}

	public boolean setEduProg(String bufString)
	{
		if (bufString.isEmpty()) 
			return (true);
		
		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols) 
		{
			if(bufString.indexOf(symb) != (-1))
				return (true);
		}

		eduProg = eduProg.copyValueOf(bufString.toCharArray());
		return (false);
	}

	public boolean setGroup(String bufString)
	{
		if (bufString.isEmpty()) 
			return (true);
		
		String invalidSymbStr = "!@#$%^&*()_+=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols) 
		{
			if(bufString.indexOf(symb) != (-1))
				return (true);
		}

		group = group.copyValueOf(bufString.toCharArray());
		return (false);
	}

	public boolean setFacultyName(String bufString)
	{
		if (bufString.isEmpty()) 
			return (true);
		
		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols) 
		{
			if(bufString.indexOf(symb) != (-1))
				return (true);
		}

		facultyName = facultyName.copyValueOf(bufString.toCharArray());
		return (false);
	}

	public boolean setAll(int bufCourse, String bufEduProg, String bufGroup, String bufFacultyName, Human bufHuman)
	{
		Student check = new Student();

		if (check.setCourse(bufCourse) || check.setEduProg(bufEduProg) || check.setGroup(bufGroup) ||
				check.setFacultyName(bufFacultyName))
			return (true);
		else
		{
			this.setCourse(bufCourse);
			this.setEduProg(bufEduProg);
			this.setGroup(bufGroup);
			this.setFacultyName(bufFacultyName);
			this.humanField.setAll(bufHuman.getId(), bufHuman.getAge(),
					bufHuman.getHeight(), bufHuman.getWeight(),bufHuman.getGender(), bufHuman.fioField);
			return (false);
		}
	}

	public int getCourse()
	{
		return(course);
	}

	public String getEduProg()
	{
		return (String.copyValueOf(eduProg.toCharArray()));
	}

	public String getGroup()
	{
		return (String.copyValueOf(group.toCharArray()));
	}

	public String getFacultyName()
	{
		return (String.copyValueOf(facultyName.toCharArray()));
	}

	public void read()
	{
		Student check = new Student();
		Scanner scanner = new Scanner(System.in);

		boolean readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter education programme:\n");
			try
			{
				check.hardSetEduProg(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter group:\n");
			try
			{
				check.hardSetGroup(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter faculty name:\n");
			try
			{
				check.hardSetFacultyName(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter course:\n");
			try
			{
				check.hardSetCourse(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		check.humanField.read();

		setAll(check.getCourse(), check.getEduProg(), check.getGroup(),
				check.getFacultyName(), check.humanField);
	}

	void display()
	{
		System.out.printf("course: %d\n", course);
		System.out.printf("direction of preparation: %s\n", eduProg);
		System.out.printf("group: %s\n", group);
		System.out.printf("faculty name: %s\n", facultyName);
		humanField.display();
	}
}
