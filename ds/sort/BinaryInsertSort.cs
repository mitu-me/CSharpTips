//折半插入排序

static void BinaryInsertSort(int[] A, int n)
{
    int i, j, low, mid, high;
    for(i=1;i<n;i++)
    {
        A[0] = A[i];//A[0]为哨兵，存放要插入到有序列表中的元素
        low = 1; high = i - 1;//折半查找范围（有序列表）
        while(low<=high)
        {
            mid = (low + high) / 2;
            if (A[mid] > A[0]) high = mid - 1;  //查左表
            else low = mid + 1;//查右表
        }

        //统一后移处理
        for(j = i-1; j>=high+1; j--) A[j + 1] = A[j];
        A[j + 1] = A[0];//插入到相应位置
    }
}
