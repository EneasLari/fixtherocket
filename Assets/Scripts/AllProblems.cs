using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using static MathematicalProblems;

public class AllProblems 
{
    static string problem = "";
    static string[] answers;
    static int correctindex = 0;
    public static void AddTaksiEnotita(bool canadd, string togglename)
    {
        if (canadd && togglename.Equals("taksi3enotita1"))
        {
            //���������� ���������� � ��������� ���.1 ������� ����� �� 1000
            problem = "��������� �������� �� ������� ��� ����� ... �����";
            answers = new string[] { "����", "�������" };
            correctindex = 0;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� ��������� ������� ������� �� ����� ����������� (�), ... (�) ��� ������� (�)";
            correctindex = 0;
            answers = new string[] { "�������", "��������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� �� �������� ���� �������� ������ �������� ����� �� ����� ��� ����������� (�), ���� ��� ������� (�) ��� ���� ��� .... (�)";
            correctindex = 1;
            answers = new string[] { "������� (�)", "������� (�)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� �� ����������� ��� ���������� �������� ����������� ����� ��� ����������� (�). �� ����� ����, ����������� ��� ������� (�). �� ��� ����� ����� ���� ��� ����������� ��� ������� (�)";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 356 �����";
            answers = new string[] { "��������", "���������" };
            correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "O ������� 356 ���� 3 ����������� (�), 5 ������� (�) ��� 6 (�������)";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 126 ���� 2 ������� (�)";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "185 > 365 ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ���������� ����� 100 ������� � ... ����� ��� 1";
            answers = new string[] { "10", "100" };
            correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ������ ����� ... ������� � ... ����� ��� 1 ";
            correctindex = 0;
            answers = new string[] { "10", "100" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "100 ������� ����� ��� ����������";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ���������� ���� ... ������� � ... ����� ��� 10";
            correctindex = 1;
            answers = new string[] { "5", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 20 ���� ���";
            correctindex = 1;
            answers = new string[] { "����������� (�)", "������� (�)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 100 ���� ... ������� � ... ����� ��� 1";
            correctindex = 1;
            answers = new string[] { "100", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 100 ���� ... ������� � ... ����� ��� 10";
            answers = new string[] { "10", "100" };
            correctindex = 0;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 100 ���� ... ����������/�� � ... ����/�� ��� 100 ";
            correctindex = 1;
            answers = new string[] { "100", "1" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 100 ����� ��� ����������. ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 100 ����� 10 ������� � ���� ����� ��� 10. ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "10 ������� ����� ��� ������. ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ���������� ����� ��� �� 10 �������";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 9 ����������� (�), 6 ������� (�) ��� 7 ������� (�). ����� ������� �����;";
            correctindex = 1;
            answers = new string[] { "769", "967" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ����� � ���� ��� 5 ���� ������ 568";
            answers = new string[] { "������� (�)", "����������� (�)" };
            correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "540<450  ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 2 ����������� ��� 9 �������. ����� ������� �����;";
            correctindex = 1;
            answers = new string[] { "290", "209" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 2 ����������� (�) ��� 3 ������� (�). ����� ������� �����;";
            correctindex = 1;
            answers = new string[] { "203", "230" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "����� ����������� ���� � ������� 308;";
            correctindex = 0;
            answers = new string[] { "3", "8" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�������� �� ���������� ������ 100-200-300";
            correctindex = 1;
            answers = new string[] { "4000", "400" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "200>196 ����� � �����";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ����� 500+2+30";
            correctindex = 0;
            answers = new string[] { "532", "523" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 306 ���������� ��";
            correctindex = 1;
            answers = new string[] { "��������� ���� ���", "��������� ���" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "200+50+10>100+100+100 ����� � �����";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 115 ��������� �� �������� ��";
            correctindex = 0;
            answers = new string[] { "100+10+5", "100+5+5" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ��� ������ 985.����� ����� � ������������";
            correctindex = 0;
            answers = new string[] { "984", "986" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
        }
        if (canadd && togglename.Equals("taksi3enotita2"))
        {
            //���������� ���������� � ��������� ���.14 ������� ����� �� 3.000

            problem = "����������� �������� �� ������� ��� ����� ... �����";
            correctindex = 1;
            answers = new string[] { "����", "�������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� �� ������� ���� ���������� ������, ������ ��� �� ����� ��� ���� ����� �� ������";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� �� �������� ���� ���������� ������, �������� �� ����� ��� ... (�), ���� ��� ����������� (�) ���� ��� ������� (�) ��� ����� ��� ������� (�)";
            correctindex = 1;
            answers = new string[] { "�������", "��������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� �� ����������� ������������ ��������, ����������� ����� ��� �������� (�).�� ����� ����, ����������� ��� ����������� (�). �� ��� ����� ����� ���� ��� ... (�) ��� ����� ��� ������� (�)";
            correctindex = 0;
            answers = new string[] { "�������", "�������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 1.456 �����";
            correctindex = 0;
            answers = new string[] { "�����������", "���������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� ���� �������� �������� ������� ����� �������� ��";
            correctindex = 0;
            answers = new string[] { "7.285", "7000285" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 2.985 ���� 2";
            correctindex = 0;
            answers = new string[] { "�������� (�)", "����������� (�)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.196<2.189 ����� � �����";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ������� ����� ��� �� ... ������� � ... ����� �� 1";
            correctindex = 1;
            answers = new string[] { "100", "1.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ������� ����� ��� �� ... ������� � ... ����� �� 10";
            correctindex = 0;
            answers = new string[] { "100", "1.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ������� ����� ��� �� ... ����������� � ... ����� �� 100";
            correctindex = 1;
            answers = new string[] { "100", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� ���� ������ �� ���� ����� ���� ����������� ���� ������� �� �� ���� ���";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 3.000 ���� 3";
            correctindex = 1;
            answers = new string[] { "�����������", "��������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 1.000 ����� ���� �� ... ����������� � ... ����� ��� 100";
            correctindex = 1;
            answers = new string[] { "100", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 1.000 ����� ��� �������. ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 1.000 ����� 10 ������������ � 10 ����� �� 100. ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "1.635>1.653 ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ������� ����� ��� �� 100 �������";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 2 �������� (�), 8 ����������� (�), 7 ������� (�) ��� 6 ������� (�). ����� ������� �����;";
            correctindex = 1;
            answers = new string[] { "2.786", "2.876" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ����� � ���� ��� 7 ���� ������ 1.785";
            correctindex = 1;
            answers = new string[] { "������� (�)", "����������� (�)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.879<2.789 ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 2 �������� (�) ��� 3 ������� (�). ����� ������� �����;";
            correctindex = 0;
            answers = new string[] { "2.003", "2.030" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 2.000 ����� �������� ����;";
            correctindex = 0;
            answers = new string[] { "2", "3" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�������� �� ���������� ������ 1.000-2.000-...";
            correctindex = 1;
            answers = new string[] { "300", "3.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.657>2.299 ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ����� 2.000+200+30+5;";
            correctindex = 0;
            answers = new string[] { "2.235", "20.235" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 2.569 ���������� ��";
            correctindex = 0;
            answers = new string[] { "��� �������� ���������� ������", "��������� ������� ��� ��������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.000+100+30+5 > 2.000+200+80+9";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 1.965 �������� ��� �������� ��";
            correctindex = 1;
            answers = new string[] { "1.000+900+5+6", "1.000+900+50+6" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ��� ������ 3.000.����� ����� � ������������;";
            correctindex = 0;
            answers = new string[] { "2.999", "2.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
        }
        if (canadd && togglename.Equals("taksi3enotita3")) 
        {
            //���������� ���������� � ��������� ���.40 ������� ����� �� 7.000

            problem = "�� ����������� ������� ����� ... �����";
            correctindex = 1;
            answers = new string[] { "����", "�������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� �� ���������� ���� ���������� ������, ������� ��� �� ����� ��� ���� ����� ��� ������� ������";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� �� �������� ���� ���������� ������, �������� ����� �� ����� ��� �������� (�), ���� ��� ... (�), ���� ��� ������� (�) ��� ����� ��� ������� (�)";
            correctindex = 0;
            answers = new string[] { "������������", "�����������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� �� ����������� ������������ ��������, ����������� ���������� �� ����� ����, ���������� ��� ��� �������� (�) ��� ������������, �� ��������� �� ��� ����������� (�), ������� (�) ��� ��� ������� (�)";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 4.956 �����";
            correctindex = 1;
            answers = new string[] { "���������", "�����������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� ���� �������� �������� ������� ����� �������� ��";
            correctindex = 1;
            answers = new string[] { "7000285", "7.285" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 5.985 ���� 9";
            correctindex = 0;
            answers = new string[] { "�������� (�)", "����������� (�)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "6.196>6.189 ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "����� �������� ����� ... ������� � ...  ����� ��� 1";
            correctindex = 1;
            answers = new string[] { "500", "5.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� �������� ����� ... ������� � ... ����� ��� 10";
            correctindex = 0;
            answers = new string[] { "600", "6.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� �������� ����� ... ����������� � ... ����� ��� 100";
            correctindex = 0;
            answers = new string[] { "70", "7.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� ���� ������ �� ���� ����� ���� ����������� ���� ������� �� �� ���� ���";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 7.000 ���� ����������� � ... ����� ��� 100";
            correctindex = 0;
            answers = new string[] { "70", "700" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 6.000 ���� ... ������� � ... ����� ��� 1";
            correctindex = 0;
            answers = new string[] { "6.000", "600" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 5.000 ���� ������� � ... ����� ��� 10";
            correctindex = 1;
            answers = new string[] { "50", "500" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 8.021 ���� 8";
            correctindex = 1;
            answers = new string[] { "����������� (�)", "��������" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 5.000 ���� 5 ��������. ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 3.000 ����� 3 ����� ��� 10 ����������� � 3 ����� ��� ...";
            correctindex = 1;
            answers = new string[] { "100", "1.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "6.785>6.816 ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "5 �������� ����� ���� �� 500 �����������";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 6 �������� (�), 5 ����������� (�), 9 ������� (�) ��� 3 ������� (�).����� ������� �����;";
            correctindex = 0;
            answers = new string[] { "6.593", "6,953" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� � ���� ��� 5 ���� ������ 5.593";
            correctindex = 1;
            answers = new string[] { "�������� (�)", "����������� (�)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "4.975>4.957 ����� � �����;";
            correctindex = 0;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ������� ���� 5 �������� ��� 3 �������. ����� ������� �����;";
            correctindex = 1;
            answers = new string[] { "5.003", "5.030" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 7.000 ����� �������� ����;";
            correctindex = 1;
            answers = new string[] { "8", "7" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�������� �� ���������� ������ 4.500-5.000-5.500-...";
            correctindex = 1;
            answers = new string[] { "6.500", "6.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "6.719>6.781 ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "���� ����� 5.000+100+6+50";
            correctindex = 0;
            answers = new string[] { "5.156", "5.165" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "� ������� 6.572 ���������� ��";
            correctindex = 1;
            answers = new string[] { "��������� �������� ���������� ��������� ���", "��� �������� ���������� ��������� ���" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "4.000+10+500+6 > 4.000+3+800+2 ����� � �����;";
            correctindex = 1;
            answers = new string[] { "�����", "�����" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "�� 5.490 �������� ��� �������� ��";
            correctindex = 0;
            answers = new string[] { "5.000+400+90", "5.000+40+0+90" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "��� ��� ������ 6.999. ����� ����� � ��������;";
            correctindex = 0;
            answers = new string[] { "7.000", "6.998" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
        }
    }
    ///TODO:prepei na ksexoriso se enotites ta problimata oste na ginontai bind me ta toggles
    public static void SetAllProblems()
    {      
 
        //���������� ���������� � ��������� ���.53 ������� ����� �� 10.000

        problem = "�� ����������� ����� ... �����";
        correctindex = 0;
        answers = new string[] { "�����", "�������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ���������� ���� ���������� ������, ������� ��� �� ����� ��� ... ����� ��� ��������� �� ������";
        correctindex = 0;
        answers = new string[] { "����", "���" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� ������������ �������� �� 1� ����� ��� �� ����� ����� ��� ������� (�), �� 2� ��� ������� (�), �� 3� ��� ����������� (�) ��� �� 4� ��� ...";
        correctindex = 1;
        answers = new string[] { "������������", "��������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ����������� ������������ ��������, ����������� ���������� �� ����� ����, ���������� ��� ��� ������� ��� ������������, �� ���������, �� ��� �������, ��� ����������� ��� ��� ��������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 10.000 �����";
        correctindex = 0;
        answers = new string[] { "�����������", "�����������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���� �������� ��������� �������� ����� �������� ��";
        correctindex = 1;
        answers = new string[] { "7.035", "7.395" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 8.495 ���� 8";
        correctindex = 1;
        answers = new string[] { "����������� (�)", "�������� (�)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� �������� ����� ���� �� ... ������� � ... ����� ��� 1";
        correctindex = 1;
        answers = new string[] { "900", "9.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� �������� ����� ���� �� ... ������� � ... ����� ��� 10";
        correctindex = 0;
        answers = new string[] { "800", "80" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� �������� ����� ���� �� ... ����������� � ... ����� ��� 100";
        correctindex = 0;
        answers = new string[] { "70", "700" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 10.000 ����� ...";
        correctindex = 0;
        answers = new string[] { "�����������", "�����������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 8.000 ����� ���� �� ... ������� � ... ����� ��� 1";
        correctindex = 1;
        answers = new string[] { "800", "8.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 9.000 ����� ���� �� ... ������� � ... ����� ��� 10";
        correctindex = 0;
        answers = new string[] { "9.000", "900" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 10.000 ����� ���� �� ... ����������� � ... ����� ��� 100";
        correctindex = 0;
        answers = new string[] { "100", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 10.000 ����� ���� �� ... �������� � ... ����� ��� 1.000";
        correctindex = 1;
        answers = new string[] { "1.000", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 7.988 ���� 7";
        correctindex = 0;
        answers = new string[] { "�������� (�)", "����������� (�)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� 9.000 ����� 9 ����� ��� 1.000 ������� � 9 ����� ��� 1.000";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "8.789<8.987 ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� �������� ����� ���� �� 90 �������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ���� 8 �������� (�), 7 �������, 9 ����������� ��� 2 ������� (�). ����� ������� �����;";
        correctindex = 1;
        answers = new string[] { "8.792", "8.972" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ���� ��� 8 ���� ������ 9.080;";
        correctindex = 0;
        answers = new string[] { "������� (�)", "������� (�)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "9.875>9.789 ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ���� 9 �������� (�), 7 ����������� (�) ��� 5 ������� (�). ����� ������� �����";
        correctindex = 0;
        answers = new string[] { "9.075", "9.705" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 10.000 ����� �������� ����;";
        correctindex = 1;
        answers = new string[] { "0", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 8.540-8.560-...";
        correctindex = 1;
        answers = new string[] { "8.570", "8.580" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� ����� ����������� ������� ��� ������ �� �������� �� �� ����� 8-6-9-3 ��� ����� ��� ����� ��� 9.000;";
        correctindex = 0;
        answers = new string[] { "8.863", "8.836" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ���� �������� �.5.986  �.7.906 �.5.896 �.7.856 . ���� � ����� ����� ��� ��� ���������� ���� ���������;";
        correctindex = 0;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 7.896 ���������� ��";
        correctindex = 1;
        answers = new string[] { "���� �������� ��������� ������ �����", "���� �������� ��������� �������� ���" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "7.000+900+5+30 > 700+30+8.000+2 ����� � �����;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 7.965-8.970-....";
        correctindex = 0;
        answers = new string[] { "7.975", "7.980" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 8.000. ����� ����� � ������������;";
        correctindex = 1;
        answers = new string[] { "7.000", "7.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));



        //���������� ���������� � ��������� ���.2 ������� ����� �� 10.000

        problem = "����������� �������� �� ������� ��� ����� ... �����";
        correctindex = 1;
        answers = new string[] { "����", "�������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ������� ���� ���������� ������, ������ ��� �� ����� ��� ���� ����� �� ������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� �� �������� ���� ���������� ������, �������� ����� �� ����� ��� ... (�), ���� ��� ����������� (�), ���� ��� ������� (�) ��� ����� ��� ������� (�) ";
        correctindex = 0;
        answers = new string[] { "��������", "�������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ����������� ������������ ��������, ����������� ����� ��� �������� (�). �� ����� ����, ����������� ��� ����������� (�). �� ��� ����� ����� ���� ��� ... ��� ����� ��� ������� (�)";
        correctindex = 0;
        answers = new string[] { "������� (�)", "������� (�)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 10.000 ����� �����������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ����� �������� ������ ������� ����� �������� ��";
        correctindex = 1;
        answers = new string[] { "9000185", "9185" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 6.780 ���� ... ����������� (�)";
        correctindex = 0;
        answers = new string[] { "6", "7" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "6.991>6.899 ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ������� ����� ... ������� � ... ����� ��� 1";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ������� ����� ... ������� � ... ����� ��� 10";
        correctindex = 0;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ������� ����� ... ����������� � ... ����� ��� 100";
        correctindex = 0;
        answers = new string[] { "10", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ������ �� �������� �� �������� �� ������������� ������� ";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 5.000 ���� ... ������� � ... ����� ��� 1";
        correctindex = 1;
        answers = new string[] { "500", "5.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 8.000 ���� ... ������� � ... ����� ��� 10";
        correctindex = 0;
        answers = new string[] { "800", "80" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 10.000 ���� ... ����������� � ... ����� ��� 100";
        correctindex = 1;
        answers = new string[] { "1.000", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "7.000+100 = 7.000+80+20 ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���� �������� ���������� ����� �������� ��";
        correctindex = 0;
        answers = new string[] { "8.905", "8905" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ���� ��� 2 ����� �������� 2.055 - 7.260 ����������;";
        correctindex = 1;
        answers = new string[] { "����������� (�) - �������� (�)", "�������� (�) - ����������� (�)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �������� ����� ���� �� 600 ����������� � 600 ����� ��� 100";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 9.785 ���� ... �������� (��)";
        correctindex = 0;
        answers = new string[] { "9", "7" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "������� ��� ������ ������ ��� 4.022 �.4.000+20+2 �.4.000+200+2 �.3.000+1.000+22 �.40+22";
        correctindex = 1;
        answers = new string[] { "�-�-�", "�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 7.000.����� ����� � ������������;";
        correctindex = 0;
        answers = new string[] { "6.999", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��� 2.500 �����";
        correctindex = 0;
        answers = new string[] { "5.000", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 5.080-5.090-...";
        correctindex = 1;
        answers = new string[] { "6.000", "5.100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ���� �������� �.2.010 �.1.009 �.2.090 �.1.000 ���� � ����� ����� ��� ��� ��������� ���� ����������;";
        correctindex = 0;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ����������� ����������� ��� ������ �� �������� �� �� ����� 6-9-5-8 ����� �� 9.856;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "1.000+2.000+50 < 3.000+50";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ �� 4 ���� ���������� ����;";
        correctindex = 0;
        answers = new string[] { "49.897", "54.697" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ���� 7 �������� (�), 6 ������� (�) ��� 5 ������� (�).����� �����;";
        correctindex = 1;
        answers = new string[] { "7.650", "7.065" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ����� �������� ������ �������� ��";
        correctindex = 0;
        answers = new string[] { "5060", "500060" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ������ 5.999.����� ����� � ��������;";
        correctindex = 1;
        answers = new string[] { "5.1000", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 7.051 ���������� ��";
        correctindex = 1;
        answers = new string[] { "���� ��� ������� ���", "���� �������� ������� ���" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //���������� ���������� � ��������� ���.3-4 ������� ����� �� 20.000

        problem = "����������� ����������� �� ������� ��� ����� ... �����";
        correctindex = 0;
        answers = new string[] { "�����", "�������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����������� ������� ������� �� ����� ������� �������� (��), ������� �������� (��), ����������� (�), ������� (�) ��� ������� (�)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� �� �������� ���� ���������� ������, �������� ����� �� ����� ��� ������� �������� (��), ���� ��� ..., ���� ��� ����������� (�), ���� ��� ������� (�) ��� ���� ��� ������� (�)";
        correctindex = 1;
        answers = new string[] { "������� ��������", "������� ��������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ��� ����� (�.�. ���� �����������) ������������ ��� ������ ��� �������� ����� (�.�. 1 ������ ��������)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 16.578 �����";
        correctindex = 0;
        answers = new string[] { "�����������", "�����������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 15.789 ���� 5";
        correctindex = 1;
        answers = new string[] { "������� �������� (��)", "������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���� ����� �������� ���������� ������� �������� ��";
        correctindex = 0;
        answers = new string[] { "15.550", "1550050" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10 ������� �������� ������������ 1 ������ ��������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���� ������� ���� ��� ����� ��� ���� ������ �������";
        correctindex = 1;
        answers = new string[] { "������� ��� ������� �� ��������", "�������� ���������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ������� ����� ��� �� 100 ������� � 100 ����� ��� 10";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ���������� ��� ���������� ������, ������� ��� �� ����� ��� ���� ����� ��� ��������� �� ������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ���� ������ �� ���� ����� ���� ���� ���� ���������� ��� �� ���� ���";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� 2x10.000+3x1.000+7x100+5x10+2x1 ��� ����� ��� ������";
        correctindex = 0;
        answers = new string[] { "23.752", "25.372" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "100 ����������� � 100 ����� ��� 100, ����� ���� �� ... ��������/�";
        correctindex = 0;
        answers = new string[] { "10", "1" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ����� ����� ��� ������� ������������ �������� ... ����� 14.030";
        correctindex = 0;
        answers = new string[] { "�������", "����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ �� 4 ���� ���������� ����;";
        correctindex = 1;
        answers = new string[] { "18.462", "14.896" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 15.678 ���� 1";
        correctindex = 0;
        answers = new string[] { "������ ������� (��)", "������� (�)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ������� ����� ... �������";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���������� �� �������� ��������� 1x10.000+2x1.000+4x...+2x10+3x1";
        correctindex = 0;
        answers = new string[] { "100", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 18.567. �� �������� ��� ������� ����� ������� ���������;";
        correctindex = 1;
        answers = new string[] { "28.567", "19.567" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 4.080-4.090-...";
        correctindex = 1;
        answers = new string[] { "5.000", "4.100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� 1x10.000+2x1.000+4x100+2x1 ��� ����� ��� ������";
        correctindex = 0;
        answers = new string[] { "12.402", "1.242" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 11.900. ����� ����� � ������������;";
        correctindex = 0;
        answers = new string[] { "11.899", "10.899" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� 1 ���� ������ 16.750 �����";
        correctindex = 1;
        answers = new string[] { "�������� (�)", "������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 17.508 �������� �� ��������";
        correctindex = 1;
        answers = new string[] { "10.000+7.000+5+0+8", "10.000+7.000+500+8" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ �� 5 ���� ���������� ����;";
        correctindex = 0;
        answers = new string[] { "5.980", "11.580" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��� ������� 3.600 �����";
        correctindex = 1;
        answers = new string[] { "61200", "7.200" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ����� ����� ��� ������� �.12.598  �.12.805 �.12.085 �.12.850 ��� ��� ���������� ���� ���������;";
        correctindex = 1;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ����� ����� ��� ������� �.12.598  �.12.805 �.12.085 �.12.850 ��� ��� ���������� ���� ���������;";
        correctindex = 1;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "9.000+... = 10.000 ���������� ��� �������";
        correctindex = 0;
        answers = new string[] { "1.000", "1" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "2 x ....=12.000 ���������� ��� �������";
        correctindex = 0;
        answers = new string[] { "6.000", "4.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10.000 : 2 = ...   ���������� ��� �������";
        correctindex = 0;
        answers = new string[] { "5.000", "500" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "19.000 - ... = 9.000 ���������� ��� �������";
        correctindex = 1;
        answers = new string[] { "10.000", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //���������� ���������� � ��������� ���.36 ������� ����� �� 100.000

        problem = "����������� ����������� �� ������� ��� ����� ... �����";
        correctindex = 0;
        answers = new string[] { "���", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ��������� ������� ������� �� ����� ����������� �������� (��), ������� �������� (��), ������� �������� (��), ����������� (�), ������� (�) ��� ������� (�)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };

        problem = "���� ������� �� �������� ���� ���������� ������, �������� ����� �� ����� ��� ... , ������� �������� (��), ���� ��� ������� �������� (��), ���� ��� ����������� (�), ���� ��� ������� (�) ��� ���� ��� ������� (�)";
        correctindex = 1;
        answers = new string[] { "������� ������������ (��)", "����������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ��� ����� (�.�. ���� �����������) ������������ ��� ������ ��� �������� ����� (�.�. 1 ������ ��������)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 100.000 ����� �����������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������ 65.002 �� 6 �����";
        correctindex = 0;
        answers = new string[] { "������� �������� (��)", "������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ������� ����� �������� �������� ��� ��������";
        correctindex = 0;
        answers = new string[] { "85202", "8500202" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10 ������� = 1 ���������� ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���� ������� ���� ��� ���� ��� ���� ������ �������";
        correctindex = 1;
        answers = new string[] { "������� ��� ������� �� ��������", "�������� ���������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ���������� ��� �������� , �������� ����� ��� �� ����� ��� ���� �� ���������� ���� (�� ����� ��� ��������). �� ����� ���, ��������� ��� ������ �������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ���������� �������� ��������, ���� ��������� ��� ... ����� �� ��� ������, ���������� ��� �� ����� ���";
        correctindex = 0;
        answers = new string[] { "����", "�������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ���� ������ �� ���� ����� ���� ����������� ���� ������� �� �� ���� ���";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 95.067 ��������� �� �������� ��������� �� 9x10.000+5x ... +6x10+7x1";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "56.302<56.039 ����� � �����;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ����� ��� ������ ������� ����� �������� �������� ��� � ������ ������� (����������� ��� ������ ��� �� ����� ���� �� ��������)";
        correctindex = 1;
        answers = new string[] { "���� �� 5", "���� �� 6" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ �� 6 ���� ��������� ����;";
        correctindex = 0;
        answers = new string[] { "50.654", "56.208" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "200 ������� ����� ���� �� ... �����������";
        correctindex = 1;
        answers = new string[] { "2", "20" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 65.100 ���� 6";
        correctindex = 0;
        answers = new string[] { "������� �������� (��)", "������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ ���� ���������� ���� �� 8;";
        correctindex = 1;
        answers = new string[] { "98.035", "89.700" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10 ������� �������� ������������ 10 ������� ��������;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 30.020-30.040-...";
        correctindex = 0;
        answers = new string[] { "30.050", "30.060" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 100.000. ����� ����� � ������������;";
        correctindex = 1;
        answers = new string[] { "999.999", "99.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 45.000. ����� ����� � ��������� ���;";
        correctindex = 1;
        answers = new string[] { "85.000", "90.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ������ ���� �������� ��������� ������� ��������";
        correctindex = 0;
        answers = new string[] { "27.830", "27.083" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "98.080>98.0..0 ���������� �� �����";
        correctindex = 1;
        answers = new string[] { "9", "1" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ����� ����� ��� ������� �.87.654 �.45.008 �.78.956 �.87.664 ��� ��� ��������� ���� ����������;";
        correctindex = 1;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "6x ... = 60.000 ���������� ��� �������";
        correctindex = 0;
        answers = new string[] { "10.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "14.670+3.580 = ... ���������� ��� �������";
        correctindex = 0;
        answers = new string[] { "18.250", "17.250" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));



        //���������� ���������� � ��������� ���.37 ������� ����� �� 200.000

        problem = "��������� ����������� �� ������� ��� ����� ... �����";
        correctindex = 0;
        answers = new string[] { "���", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ��������� ������� ������� �� ����� ����������� �������� (��), ������� �������� (��), ������� �������� (��), ����������� (�), ������� (�) ��� ������� (�)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� �� �������� ���� ���������� ������, �������� ����� �� ����� ��� ... (��), ������� �������� (��), ���� ��� ������� �������� (��), ���� ��� ����������� (�), ���� ��� ������� (�) ��� ���� ��� ������� (�)";
        correctindex = 1;
        answers = new string[] { "������� �������� (��)", "����������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ��� ����� (�.�. ���� �����������) ������������ ��� ������ ��� �������� ����� (�.�. 1 ������ ��������)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ... ����� ���� ��������� �������";
        correctindex = 1;
        answers = new string[] { "100.004", "12.980" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 136.567 ���� 1";
        correctindex = 1;
        answers = new string[] { "������ ������� (��)", "���������� ������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ������ ������� �������� ��������";
        correctindex = 0;
        answers = new string[] { "150000", "1500000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� �������� ������������ ��� ������ �������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �� ����������� ��� �������� �������� ����� ��� �� ����� ��� ���� ��� ���������� ���� (�� ����� ��� ��������). �� ����� �� ���� ��������� ��� ������ �������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� ��������� ����� � ������� ��� ������� ���� ��� ����� ���� ������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� ��������� ����� � ������� ��� ������� ���� ��� ����� ���� ������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "100 �������� � 100 ����� ��� 1.000. ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "100 �� ���� ������ �� ���� ����� ���� ����������� ���� ������� �� �� ���� ���";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "205.176>208.053 ����� � �����;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� 1x100.000+5x10.000+1x1.000+1x10+5x1 ��� ����� ��� ������";
        correctindex = 0;
        answers = new string[] { "151.105", "151.015" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 10.000 ����� ���� �� ... ������� � ... ����� �� 10";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "1.000 ����������� = 1 ���������� ������� ����� � �����;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ����� �������� �������� ����� �������� ��";
        correctindex = 0;
        answers = new string[] { "100.205", "100.000.205" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 105.690 ���� 1";
        correctindex = 0;
        answers = new string[] { "���������� ������� (��)", "������ ������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� �������� ������������ 1 ... ";
        correctindex = 0;
        answers = new string[] { "���������� ������� (��)", "������ ������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� ��� ������� 100.050 �����";
        correctindex = 1;
        answers = new string[] { "1x100.000+50x10", "1x100.000+5x10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 135.200-135.800- ...";
        correctindex = 0;
        answers = new string[] { "136.200", "136.400" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ����� 3x40.000;";
        correctindex = 0;
        answers = new string[] { "120.000", "12.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 116.000. ����� ����� � ������������;";
        correctindex = 1;
        answers = new string[] { "115.000", "115.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� 1x100.000+4x10.000+9x1.000+5x10 ��� ����� ��� ������";
        correctindex = 0;
        answers = new string[] { "149.050", "149.005" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ ��� 7 ���� ���������� ����;";
        correctindex = 1;
        answers = new string[] { "197.856", "176.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "1.000 ����������� = 1 ���������� ������� ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ����� ����� ��� ������� �.101.234 �.100.251 �.110.008 �.101.432 ��� ��� ��������� ��� ����������;";
        correctindex = 0;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� �������� � ������� ����� �������� ���������� �����;";
        correctindex = 1;
        answers = new string[] { "150.005", "100.505" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��� ������� 100.005 �����";
        correctindex = 1;
        answers = new string[] { "200.100", "200.010" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ��� ������ 50.000. �� �������� ����� ��������, ����� ������� ���������;";
        correctindex = 0;
        answers = new string[] { "150.000", "510.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "165.628>165.691 ����� � �����;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "120.000 : ...=60.000";
        correctindex = 0;
        answers = new string[] { "2", "6" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //���������� ���������� � ��������� ���.47 ������� ����� �� 1.000.000

        problem = "���� ���������� ������� (�.�. 1.000.000) ������ �� ���� ������� ������������ (��), ����������� �������� (��), ������� �������� (��), ������� �������� (��), ����������� (�), ������� (�) ��� ������� (�)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ��� ������������ � ������� ������������ (��) ����� 10 ����� ���������� ��� ������ ��� ����������� �������� (��).";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ��� ������������ � ������� ������������ (��) ����� 100 ����� ���������� ��� ������ ��� ������� �������� (��)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ��� ������������ � ������� ������������ (��) ����� 1.000 ����� ���������� ��� ������ ��� ������� �������� (��)";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 956.000 ���� 5";
        correctindex = 0;
        answers = new string[] { "������� �������� (��)", "����������� �������� (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ����� ���� �� ... ����������� �������� � ... ����� �� 100.000";
        correctindex = 1;
        answers = new string[] { "100", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ����� ���� �� ... ������� �������� � ... ����� ��� 10.000";
        correctindex = 1;
        answers = new string[] { "10", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ����� ���� �� ... �������� � ... ����� ��� 1.000";
        correctindex = 1;
        answers = new string[] { "10.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ��� �� �������, �������, �����������, �������� ������ ���� ��� ����� ���� ������ ����������";
        correctindex = 0;
        answers = new string[] { "�������� ���������", "������� �� ��������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� �� ����������� ��� �������� �������� ��� �� ����� ��� ��������� ����� ��� �����. �� ����� ���� ����������� ��� ������ �������.";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ���� ������ �� ���� ����� ���� ����������� ���� ������� �� �� ���� ���";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.054.650 ��������� �� �������� ��������� �� 1x100.000.000+5x1.000+4x100+6x10+5x1";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "965.567>1.000.000 ����� � �����;";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ �� 6 ���� ���������� ����;";
        correctindex = 0;
        answers = new string[] { "560.000", "786.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ����� ���� �� ... ����������� � ... ����� ��� 100";
        correctindex = 1;
        answers = new string[] { "100", "10.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ����� ���� �� ... �������";
        correctindex = 0;
        answers = new string[] { "1.000.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ����� ���� �� ... ������� � ... ����� ��� 10";
        correctindex = 1;
        answers = new string[] { "1.000.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� 6x1.000.000+7x10.000+3X10+8x1 ��� ����� ��� ������";
        correctindex = 0;
        answers = new string[] { "6.070.031", "6.731.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�������� �� ���������� ������ 800.000-900.000- ...";
        correctindex = 1;
        answers = new string[] { "1000.000", "1.000.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "7...0.869>710.100 ���������� ��� ������ ��� �� ������ � �������";
        correctindex = 0;
        answers = new string[] { "1", "0" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� � ����� ����� ��� ������� �.900.100 �.900.010 �.901.000 �.910.000 ��� ��� ���������� ���� ���������;";
        correctindex = 1;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 ���� 1";
        correctindex = 0;
        answers = new string[] { "������ ������������ (��)", "������ ������������ (��)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ����� ������ �� 6 ���� ���������� ����;";
        correctindex = 1;
        answers = new string[] { "860.000", "610.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ���� ��� 600.000 �����";
        correctindex = 0;
        answers = new string[] { "300.000", "200.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ��������� ��� 300.000 �����";
        correctindex = 0;
        answers = new string[] { "900000", "90.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "240.000+ ... = 620.000 ���������� ��� �������";
        correctindex = 1;
        answers = new string[] { "360.000", "380.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "... x 3 = 180.000 ���������� ��� �������";
        correctindex = 0;
        answers = new string[] { "60.000", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� ������� ����� ������� ��� 654.010 ��� �� 655.010";
        correctindex = 0;
        answers = new string[] { "654.000", "655.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��������� 5x100.000+8x10.000+6x1 ��� ����� ��� ������";
        correctindex = 0;
        answers = new string[] { "580.001", "581.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� ����� � ������������ ������� ��� 600.000;";
        correctindex = 1;
        answers = new string[] { "599.000", "599.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //���������� ���������� � ��������� ���.3 ������� �������

        problem = "�� ������� 0,1,2,3,...,100,101,...,1.000,1.000.000.... �������� ������� �������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "������ ����� �� ������� ��� ������� ���� ���������� ��� 2";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ���������� ��� ���� ������� ����� �� �������� �������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ������� ������� ���� ���� ������� ��� ��� ����������� ����� ��� �� 0 ��� ��� ���� �����������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 1.000.000 �����";
        correctindex = 0;
        answers = new string[] { "���������", "����������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ������� 300.005 ����� ������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ������� 650.000 ����� ��������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������������ ������� ��� 10.000.000 �����";
        correctindex = 1;
        answers = new string[] { "99.999.999", "9.999.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "������� ��� 6 ��� �� 8 ��� ������� �������� �������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� 0 ����� � ���������� ������� �������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "��� ������� ����������� ������� ������� ��� ��� ���� ������ ������ ������� � �������� ���";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "������� ��� 4 ��� �� 5 ������� ������� �������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� 80.002 ����� ... ������� �������";
        correctindex = 0;
        answers = new string[] { "������", "��������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� 1.000 ����� � ����������� ����������� ������� �������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� �������� ������� ��� 99.099 �����";
        correctindex = 1; 
        answers = new string[] { "100.000", "99.100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���������� �������� ���������� ������ �������� ��";
        correctindex = 0;
        answers = new string[] { "700.560", "705.060" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 950.002 ����� ������ �������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� 100.000 ����� � ... ��������� �������";
        correctindex = 0;
        answers = new string[] { "����������", "�����������" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� ����� � �������� ������� ��� 590.999;";
        correctindex = 1;
        answers = new string[] { "600.000", "591.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ��� ����������� ������ ����� ��������";
        correctindex = 1;
        answers = new string[] { "1.065.000", "1.000.065" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "765.234 ... 756.999 ���������� ��� �������";
        correctindex = 1;
        answers = new string[] { "<", ">" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� ���� �������������� �������� ��";
        correctindex = 0;
        answers = new string[] { "10.000.000.000", "10.000.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 654.000 ����� ������";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������� 654.000 ����� ��������";
        correctindex = 1;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� ���� ��� 1.000.000 �����";
        correctindex = 1;
        answers = new string[] { "5.000.000", "500.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "�� �������� ��� 3.000.000 �����";
        correctindex = 1;
        answers = new string[] { "9.000.000", "6.000.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "���� ���� �������� ��� ��� ��������� ���� ���������� �.6.980.000 �.6.890.00 �.6.089.000 �.6.809.000";
        correctindex = 1;
        answers = new string[] { "�-�-�-�", "�-�-�-�" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "����� ����� � ������� ������� 13 ����������� 40 �������;";
        correctindex = 0;
        answers = new string[] { "13.000.040", "13.000.000.040" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "350 ����������� 25 �������� = 350.025.000 ����� � �����;";
        correctindex = 0;
        answers = new string[] { "�����", "�����" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "200 �����������, 20 �������� ���� � �������";
        correctindex = 1;
        answers = new string[] { "200.000.020", "200.020.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� �������� ������� ��� 3.009.000 �����";
        correctindex = 1;
        answers = new string[] { "3.009.001", "3.010.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "� ������������ ������� ��� 9.000.900 �����";
        correctindex = 1;
        answers = new string[] { "9.000.800", "9.000.899" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


}
    //#region MATHPROBLEM class
    //public class MathProblem
    //{

    //    public string Problem = null;
    //    public string[] Answers = null;
    //    public int CorrectAnswerIndex = 0;

    //    public MathProblem(string problem, string[] answers, int correctindex)
    //    {
    //        Problem = problem;
    //        Answers = answers;
    //        CorrectAnswerIndex = correctindex;
    //    }

    //}
    //#endregion
}
