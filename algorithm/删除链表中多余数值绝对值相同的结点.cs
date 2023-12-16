class Node {
    int data;
    Node next = null;

    /*
     * 用单链表保存m个整数，且data < n,设计一个算法，对于链表中data绝对值相等的结点，
     * 仅仅保留第一次出现的结点而删除其余绝对值相等的结点
     * 
     * */
    public void Func(Node head, int n)
    {
        //初始化n个数组
        int[] index = new int[n];
        for(int i=0;i<n;i++)
            index[i] = i;

        // 定义一个结点来记录当前结点的前驱结点
        Node pre_node = head;
        Node tp = pre_node.next;
        //开始遍历整个链表
        while (head.next != null)
        {
            // 如果是第一次遍历，则将对应位置的index[tp]设置为1
            if (index[tp.data] == 0) index[tp.data] = 1;
            //否则就把当前元素对应的结点删除(断链即可)
            else {
                pre_node.next = tp.next;
            }
            pre_node = pre_node.next;
            tp = pre_node.next;
        }
    }
}
