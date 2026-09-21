public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public bool isEnd = false;
}
public class WordDictionary {
    private TrieNode root;


    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode curr = root;

        foreach(char c in word)
        {
            int i = c-'a';
            if(curr.children[i]==null)
            {
                curr.children[i]= new TrieNode();
            }
            curr = curr.children[i];
        }
        curr.isEnd = true;
    }
    
    public bool Search(string word) {
        
        return searchHelper(0, word, root);
    }

    public bool searchHelper(int i, string word, TrieNode node)
    {
        TrieNode curr = node;
        for(; i<word.Length; i++)
        {
            char c = word[i];
            if(c=='.')
            {
                foreach(var child in curr.children)
                {
                    if(child!=null)
                    {
                        if(searchHelper(i+1, word, child))
                        {
                            return true;
                        }
                    }

                }
                    return false;
            }
            else
            {
                int index = c-'a';
                if(curr.children[index]== null)
                    return false;
                curr = curr.children[index];
            }
        }
        return curr.isEnd;
    }
}
