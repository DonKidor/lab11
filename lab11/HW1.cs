    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        long[] q = new long[n];
        for (int i = 0; i < n; i++) q[i] = 0;
        foreach(int c in customers)
        {
            int minIndex = 0;
            for(int j=0; j<n; j++)
            {
                if(q[j] < q[minIndex]) minIndex = j;
            }
            q[minIndex] += c;
        }
        long maxValue = q[0];
        foreach(long val in q)
        {
            if (val > maxValue) maxValue = val;
        }
        return maxValue;
    }
}
