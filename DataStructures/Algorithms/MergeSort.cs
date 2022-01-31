//public static List<double> runningMedian(List<int> a)
//{
//    List<double> median = new List<double>();

//    int i, j, l = a.Count, temp;
//    double sum, count, m;
//    for (i = 0; i < l; i++)
//    {

//        temp = a[i];
//        j = i - 1;

//        m = Convert.ToDouble(a.Take(i + 1).Sum()) /
//        Convert.ToDouble(a.Take(i + 1).Count());

//        median.Add(m);

//        while (j >= 0 && a[j] > temp)
//        {
//            a[j + 1] = a[j];
//            j--;
//        }
//        a[j + 1] = temp;
//    }
//    return median;
//}