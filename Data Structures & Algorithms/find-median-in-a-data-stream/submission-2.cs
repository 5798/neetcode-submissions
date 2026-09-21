public class MedianFinder {
    PriorityQueue<int, int> minh = new PriorityQueue<int,int>();
    PriorityQueue<int, int> maxh = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=> b.CompareTo(a)));

    public MedianFinder() {
    }
    
    public void AddNum(int num) {
        if(maxh.Count==0)
        {
            maxh.Enqueue(num, num);
        }
        else if(num<=maxh.Peek())
        {
            maxh.Enqueue(num, num);
        }
        else
        {
            minh.Enqueue(num, num);
        }
        
        if(maxh.Count+1 < minh.Count)
        {
            int val =minh.Dequeue();
            maxh.Enqueue(val, val);
        }
        else if(maxh.Count > minh.Count+1)
        {
            int val =maxh.Dequeue();
            minh.Enqueue(val, val);
        }
    }
    
    public double FindMedian() {
        if(minh.Count>maxh.Count)
        {
            return minh.Peek();
        }
        else if(maxh.Count>minh.Count)
        {
            return maxh.Peek();
        }
        return (minh.Peek() + maxh.Peek() )/2.0 ;
    }
}
