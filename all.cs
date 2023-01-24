using System; 

class Program
{
     static void output_mass(int[] mass)
    {
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write($"{mass[i] } ");
        }
        Console.WriteLine("");
    }
    static int[] fastsort(int[] mass, int f, int l){
		int mid = mass[mass.Length/2];
		int temp;
		while ( l > f)
		{
			while (mass[f] < mid) f++;
			while (mass[l] > mid) l--;
			if (l >= f) {
				temp = mass[f];
				mass[f] = mass[l];
				mass[l] = temp;
				l--;
				f++;
				}
			}
			return mass;
		}
		
    static void input_mass(out int[] mass, int a, int b)
    {
        mass = new int[b - a + 1];
        int k = 0;
        for (int i = a; i <= b - 1; i++)
        {
            mass[k] = i;
            k++;
        }
    }

    static int[] selection_sort(int[] mass)
    {
        int min;
        int temp;
        int pos=0;
        int k = 0;
        while (k < mass.Length )
            
        {
            min = mass[k];
            for (int i = k; i < mass.Length; i++)
            {
                if (mass[i] < min) 
                { min = mass[i]; pos = i; }
            }
            temp = mass[k];
            mass[k] = min;
            mass[pos] = temp;
            k++;
            
        }
        return mass;
    }
    static int[] stupid_sort(int[] mass) {
        int temp;
        for (int i = 0; i < mass.Length-1;) {
            if (mass[i + 1] > mass[i]) i++;
            else { temp = mass[i + 1];
                mass[i + 1] = mass[i];
                mass[i] = temp;
                i = 0;
            }
        }
        return mass;
    }
    static void rev_buble_sort(int[] mass)
    {
        int temp;
        int cur;
        for (int i = 0; i < mass.Length; i++)
        {
            
            for (int j = i; j < mass.Length-1; j++)
            {
             if (mass[j] > mass[j+1] )
                {
                    temp = mass[j+1];
                    mass[j+1] = mass[j];
                    mass[j] = temp;
                }
 
            }
        }
        
    }
    public static void Main()
    {
        int[] mass = new int[] { 6, 1, 2, 8, 3 };
        rev_buble_sort(mass);
    }

}
