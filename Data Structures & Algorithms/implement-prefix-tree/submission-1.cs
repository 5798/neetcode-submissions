
public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public bool isEnd = false;
}
public class PrefixTree {

    private TrieNode root;
    
    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach (char c in word)
        {
            int i = c-'a';
            if(curr.children[i] == null)
            {
                curr.children[i] = new TrieNode();  
            }
            curr = curr.children[i];
        }
        curr.isEnd = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;
        foreach(char c in word)
        {
            int i = c-'a';
            if(curr.children[i] == null)
            {
                return false;  
            }
            curr = curr.children[i];
        }
        return curr.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = root;
        foreach(char c in prefix)
        {
            int i = c-'a';
            if(curr.children[i] == null)
            {
                return false;  
            }
            curr = curr.children[i];
        }
        return true;
    }
}
