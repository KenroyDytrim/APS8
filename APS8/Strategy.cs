using APS8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace APS8
{
    public interface Strategy
    {
        List<string> Algorithm(int[] mass, int v);
    }
}

public class BubbleSort : Strategy
{
    public List<string> Algorithm(int[] mass, int v)
    {
        List<string> massL = new List<string>();
        string buff = " ";
        var len = mass.Length;
        massL.Add("Исходная последовательность\n");
        massL[massL.Count - 1] += (String.Join(",", mass));

        switch (v)
        {
            case 0:
                for (var i = 1; i < len; i++)
                {
                    for (var j = 0; j < len - i; j++)
                    {
                        if (mass[j] > mass[j + 1])
                        {
                            Swap(ref mass[j], ref mass[j + 1]);
                            buff = String.Join(",", mass);
                            massL.Add($"{mass[j + 1]}<---->{mass[j]}\n");
                            massL[massL.Count - 1] += (buff);
                        }
                    }
                }
                break;
            case 1:
                for (var i = 1; i < len; i++)
                {
                    for (var j = 0; j < len - i; j++)
                    {
                        if (mass[j] < mass[j + 1])
                        {
                            Swap(ref mass[j], ref mass[j + 1]);
                            buff = String.Join(",", mass);
                            massL.Add($"{mass[j + 1]}<---->{mass[j]}\n");
                            massL[massL.Count - 1] += (buff);
                        }
                    }
                }
                break;
        }

        return massL;
    }

    static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }
}

public class SelectionSort : Strategy
{
    public List<string> Algorithm(int[] mass, int v)
    {
        List<string> massL = new List<string>();
        string buff = " ";
        massL.Add("Исходная последовательность\n");
        massL[massL.Count - 1] += (String.Join(",", mass));

        switch (v)
        {
            case 0:
                for (int i = 0; i < mass.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < mass.Length; j++)
                    {
                        if (mass[j] < mass[min])
                        {
                            min = j;
                        }
                    }
                    Swap(ref mass[i], ref mass[min]);
                    buff = String.Join(",", mass);
                    massL.Add($"{mass[min]}<---->{mass[i]}\n");
                    massL[massL.Count - 1] += (buff);
                }
                break;
            case 1:
                for (int i = 0; i < mass.Length - 1; i++)
                {
                    int max = i;
                    for (int j = i + 1; j < mass.Length; j++)
                    {
                        if (mass[j] > mass[max])
                        {
                            max = j;
                        }
                    }
                    Swap(ref mass[i], ref mass[max]);
                    buff = String.Join(",", mass);
                    massL.Add($"{mass[max]}<---->{mass[i]}\n");
                    massL[massL.Count - 1] += (buff);
                }
                break;
        }

        return massL;
    }
    static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }
}

public class GnomeSort : Strategy
{
    public List<string> Algorithm(int[] mass, int v)
    {
        List<string> massL = new List<string>();
        string buff = " ";
        massL.Add("Исходная последовательность\n");
        massL[massL.Count - 1] += (String.Join(",", mass));
        var index = 1;
        var nextIndex = index + 1;

        while (index < mass.Length)
        {
            switch (v)
            {
                case 0:
                    if (mass[index - 1] < mass[index])
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                    else
                    {
                        Swap(ref mass[index - 1], ref mass[index]);
                        buff = String.Join(",", mass);
                        massL.Add($"{mass[index]}<---->{mass[index - 1]}\n");
                        massL[massL.Count - 1] += (buff);
                        index--;
                        if (index == 0)
                        {
                            index = nextIndex;
                            nextIndex++;
                        }
                    }
                    break;
                case 1:
                    if (mass[index - 1] > mass[index])
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                    else
                    {
                        Swap(ref mass[index - 1], ref mass[index]);
                        buff = String.Join(",", mass);
                        massL.Add($"{mass[index]}<---->{mass[index - 1]}\n");
                        massL[massL.Count - 1] += (buff);
                        index--;
                        if (index == 0)
                        {
                            index = nextIndex;
                            nextIndex++;
                        }
                    }
                    break;
            }   
        }

        return massL;
    }
   
    static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }
}

public class Context
{
    public Strategy ContextStrategy { get; set; }

    public Context(Strategy _strategy)
    {
        ContextStrategy = _strategy;
    }

    public List<string> ExecuteAlgorithm(int[] mass, int v)
    {
        return ContextStrategy.Algorithm(mass, v);
    }
}