public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        foreach(var i in s)
        {
            if(i==')')
            {
                if(st.Count==0 || st.Pop()!='(')
                    return false;
            }
            else if(i=='}')
            {
                if(st.Count==0 || st.Pop()!='{')
                    return false;
            }
            else if(i==']')
            {
                if(st.Count==0 || st.Pop()!='[')
                    return false;
            }
            else
                st.Push(i);


        }
        if(st.Count==0)
            return true;
        else
            return false;
    }
}
