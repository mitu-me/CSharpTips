/**
 * 选择排序(不稳定)：每一趟在待排序元素中选择关键字最小的元素加入到有序子序列
 * 总共进行n-1趟处理 
 * 空间复杂度:O(1)
 * 平均时间复杂度:O(n^n)
 * 
 */

static void SelectSort(int[] A, int n)
{ 
    for(int i=0;i<n;i++)    //一共进行n-1趟,i所指前面的元素全部有序
    {
        int min = i;    //记录最小元素位置
        for(int j=i+1;j<n;j++)  //在L[i+1,n-1]中选择最小的元素
        {
            if (A[j] < A[min])
                min = j;    //找到就把最小值的下标给min
        }
        if (min != i)
        {
            int tmp = A[i];
            A[i] = A[min];
            A[min] = tmp;
        }
    }
}
