/**
 * 快速排序(不稳定)：在带待排序表L[1,...,n]中任选取一个元素base作为基准元素（通常取首元素），
 * 通过一趟排序将待排序表划分为独立的两部分L1[1,..,k-1]和L2[k+1,...,n],
 * 使得L1中的所有元素小于等于base,L2中的元素大于等于base。然后递归重复以上过程，
 * 直到每部分表内只有一个元素或者空为止，及所有的元素都在最终位置
 * 
 * 空间复杂度:O(递归层数)==>n*log2(n)
 * 平均时间复杂度:O(n*递归层数)
 * 
 */

static void QuickSort(int[] A, int low, int high)
{
    if(low < high)  //递归退出条件
    {
        int base_pos = Partition(A, low, high); //划分
        QuickSort(A, low, base_pos - 1);  //划分左子表
        QuickSort(A, base_pos + 1, high); //划分右子表
    }
}
static int Partition(int[] A, int low, int high)
{
    int base = A[low];  //第一个元素作为基准元素
    while(low<high)
    {
        //比基准小的元素左移到A[low]空白处
        while (low < high && base <= A[high])  high--;
        A[low] = A[high]);
        //比基准大的元素右移到A[high]空白处
        while (low < high && base >= A[low]) low++;
        A[high] = A[low];
    }   
    A[low] = base;  //基准元素最终存在low处
    return low;     //返回基准元素最终的位置

}
