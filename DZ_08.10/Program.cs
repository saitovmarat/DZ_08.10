using System;

namespace DZ_08._10
{
    class Program
    {
        struct Citizen
        {
            public string name;
            public int pasport;
            public string problem;
            public int problem_num;
            public int agresion_temp;
            public int smart_temp;
            public Citizen(string name, int pasport, string problem, int problem_num, int agresion_temp, int smart_temp)
            {
                this.name = name;
                this.pasport = pasport;
                this.problem = problem;
                this.problem_num = problem_num;
                this.agresion_temp = agresion_temp;
                this.smart_temp = smart_temp;
            }
        }
        static void Task2(int[] first_team, int[] second_team)
        {
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < first_team.Length; i++)
            {
                if ((int)first_team[i] == 5)
                {
                    cnt1++;
                }
            }
            for (int j = 0; j < second_team.Length; j++)
            {
                if (second_team[j] == 5)
                {
                    cnt2++;
                }
            }
            if (cnt1 == cnt2)
            {
                Console.WriteLine("Drinks All Round!Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        static void Main(string[] args)
        {
            int[] first_team = new int[] {1, 5, 6, 5, 5, 7, 8 };
            int[] second_team = new int[] {1, 5, 6, 5, 5, 5, 5};
            Task2(first_team, second_team);
        }
    }
}
