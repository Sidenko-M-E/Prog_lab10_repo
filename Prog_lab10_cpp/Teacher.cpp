#include "Teacher.h"
#include <iostream>
#include <cmath>


void Teacher::HardSetWorkExp(int buf)
{
	if (buf < 0 || buf > 60)
		throw invalid_argument("Invalid range of number.");
	else
		workExp = buf;
}

void Teacher::HardSetDegree(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"?;:?*,./'][{}<>~`";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	degree = bufString;
}

void Teacher::HardSetFacultyName(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"?;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	facultyName = bufString;
}

bool Teacher::SetWorkExp(int buf)
{
	if (buf < 0 || buf > 60)
		return (true);
	else
	{
		workExp = buf;
		return (false);
	}
}

bool Teacher::SetDegree(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"?;:?*,./'][{}<>~`";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	degree = bufString;
	return (false);
}

bool Teacher::SetFacultyName(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"?;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	facultyName = bufString;
	return (false);
}

int Teacher::GetWorkExp()
{
	return (workExp);
}

string Teacher::GetDegree()
{
	return (degree);
}

string Teacher::GetFacultyName()
{
	return (facultyName);
}


Teacher Teacher::operator+(int operatorWorkExp)
{
	Teacher resultObject;
	resultObject.workExp = this->workExp + operatorWorkExp;
	resultObject.degree = this->degree;
	resultObject.facultyName = this->facultyName;
	resultObject.humanField = this->humanField;
	return (resultObject);
}

int operator+(int operatorWorkExp, Teacher operatorTeacher)
{
	return (operatorTeacher.workExp + operatorWorkExp);
}

Teacher& Teacher::operator++()//prefix
{
	this->workExp++;
	return *this;
}

Teacher Teacher::operator++(int unused)//postfix
{
	Teacher resultObject = *this;
	++*this;
	return resultObject;
}

double Teacher::GetSalaryOf(Teacher& bufTeacher)
{
	double result = 0;
	int bufWorkExp = bufTeacher.GetWorkExp();
	if (bufWorkExp >= 0 && bufWorkExp <= 3)
		result = baseSalary;

	if (bufWorkExp >= 4 && bufWorkExp <= 7)
		result = baseSalary * 1.3;

	if (bufWorkExp >= 8 && bufWorkExp <= 14)
		result = baseSalary * 1.6;

	if (bufWorkExp >= 15 && bufWorkExp <= 24)
		result = baseSalary * 2.2;

	if (bufWorkExp >= 25)
		result = baseSalary * 3.1;

	result = round(result * 100) / 100;
	return (result);
}

double Teacher::baseSalary = 23456.78;


Teacher::Teacher()
{
	workExp = 0;
	degree = "unstated";
	facultyName = "unstated";
}

Teacher::Teacher(Human bufHuman)
{
	workExp = 0;
	degree = "unstated";
	facultyName = "unstated";
	humanField = bufHuman;
}

Teacher::Teacher(int bufWorkExp, string bufDegree, string bufFacultyName, Human bufHuman)
{
	Teacher check;

	if (check.SetWorkExp(bufWorkExp) || check.SetDegree(bufDegree) || check.SetFacultyName(bufFacultyName))
	{
		workExp = 0;
		degree = "unstated";
		facultyName = "unstated";
	}
	else
	{
		workExp = bufWorkExp;
		degree = bufDegree;
		facultyName = bufFacultyName;
		humanField = bufHuman;
	}
}


void Teacher::Read()
{
	Teacher check;
	string bufString;

	bool readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter working experience:" << endl;
			getline(cin, bufString);
			check.HardSetWorkExp(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter scientific degree:" << endl;
			getline(cin, bufString);
			check.HardSetDegree(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
				
	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter faculty name:\n";
			getline(cin, bufString);
			check.HardSetFacultyName(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
	
	check.humanField.Read();

	workExp = check.GetWorkExp();
	degree = check.GetDegree();
	facultyName = check.GetDegree();
	humanField = check.humanField;
}

void Teacher::Display()
{
	cout << "working experience: " << workExp << " years" << endl;
	cout << "scientific degree: " << degree << endl;
	cout << "faculty name: " << facultyName << endl;
	humanField.Display();
}

