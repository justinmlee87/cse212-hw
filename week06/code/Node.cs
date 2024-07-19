public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;  // Found the value at the current node
        }
        else if (value < Data)
        {
            // Search in the left subtree
            if (Left != null)
                return Left.Contains(value);
            else
                return false;  // Value not found (left subtree is null)
        }
        else  // value > Data
        {
            // Search in the right subtree
            if (Right != null)
                return Right.Contains(value);
            else
                return false;  // Value not found (right subtree is null)
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Base case: if the node is null, height is 0
        if (this == null)
        {
            return 0;
        }

        // Recursive case: calculate the height of left and right subtrees
        int leftHeight = (Left == null) ? 0 : Left.GetHeight();
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();

        // Height of current node is 1 plus the maximum of left or right subtree heights
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}